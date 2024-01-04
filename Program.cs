using EosSharp;
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using EosSharp.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateWaxPK
{
    class Program
    {
        const string PrimaryKeyPrefix = "pk:";
        const string TestNetFlag = "testnet";
        const string TestNetContractName = "nkcss55nkcss";
        const int ExpectedPrivateKeyLength = 51;

        const string WaxMainNetChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4";
        const string WaxMainNetApiUrl = "https://wax.greymass.com";
        const string WaxTestNetChainId = "f16b1833c747c43682f4386fca9cbb327929334a762755ebec17f6f23c9b8a12";
        const string WaxTestNetApiUrl = "https://testnet.waxsweden.org";

        static async Task<(string result, string tx, bool error)> Execute(EosApi api, params EosSharp.Core.Api.v1.Action[] actions)
        {
            (string result, string tx, bool error) result;
            var wax = new Eos(api.Config);
            var abiSerializer = new EosSharp.Core.Providers.AbiSerializationProvider(api);
            var trx = new Transaction
            {
                max_net_usage_words = 0,
                max_cpu_usage_ms = 0,
                delay_sec = 0,
                context_free_actions = new List<EosSharp.Core.Api.v1.Action>(),
                transaction_extensions = new List<Extension>(),
                actions = actions.ToList(),
            };
            var packedTrx = await abiSerializer.SerializePackedTransaction(trx);
            var requiredKeys = (await api.Config.SignProvider.GetAvailableKeys()).ToList();
            var signatures = await api.Config.SignProvider.Sign(api.Config.ChainId, requiredKeys, packedTrx);
            try
            {
                string tx = await wax.CreateTransaction(trx);
                result = (null, tx, false);
            }
            catch (ApiErrorException ex)
            {
                Console.WriteLine("An error has occured:");
                var parts = ex.error.details.FirstOrDefault()?.message?.Split(':');
                if ((parts?.Length ?? 0) == 2)
                {
                    result = (parts[1].Trim(), null, true);
                }
                else
                {
                    result = (string.Join(Environment.NewLine, ex.error.details.Select(x => x.message)), null, true);
                }
                Console.WriteLine(result.result);
            }
            return result;
        }
        static async Task Main(string[] args)
        {
            bool UseTestNet = false;
            Abi2CSharp.Model.eosio.Name wallet = null;
            string pk = null;
            if ((args?.Length ?? 0) > 1)
            {
                pk = args[0];
                if (pk.StartsWith(PrimaryKeyPrefix)) pk = pk.Substring(PrimaryKeyPrefix.Length);
                if (pk.Length != ExpectedPrivateKeyLength)
                {
                    pk = pk.Trim('"');
                    if (File.Exists(pk)) pk = File.ReadAllText(pk).Trim();
                    else
                    {
                        Console.WriteLine($"You need to specify the private key as the first argument; either as {PrimaryKeyPrefix}5...(52 characters total) or as a path to a filename holding the Private Key");
                        Environment.Exit(2);
                    }
                }
                try
                {
                    wallet = args[1];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing wallet name '{args[1]}': {ex.Message}");
                    Environment.Exit(4);
                }
                if (args.Length > 2)
                {
                    if(args[2] == TestNetFlag)
                    {
                        UseTestNet = true;
                    }
                    else
                    {
                        Console.WriteLine($"The second argument can only be '{TestNetFlag}' to not execute against mainnet.");
                        Environment.Exit(3);
                    }
                }
            }
            else
            {
                Console.WriteLine($"You need to specify the private key as the first argument; either as {PrimaryKeyPrefix}:5...(52 characters total) or as a path to a filename holding the Private Key, followed by the wallet name, and optionally '{TestNetFlag}' if you want to execute against testnet.");
                Environment.Exit(1);
            }

            string ChainId = UseTestNet ? WaxTestNetChainId : WaxMainNetChainId;
            string ApiUrl = UseTestNet ? WaxTestNetApiUrl : WaxMainNetApiUrl;

            var api = new EosApi(new EosConfigurator
            {
                SignProvider = new EosSharp.Core.Providers.DefaultSignProvider(pk),
                HttpEndpoint = ApiUrl,
                ChainId = ChainId
            }, new HttpHandler());
            var req = Abi2CSharp.Contracts.boost_wax.Requests.noop.CreateAction(wallet, new Abi2CSharp.Contracts.boost_wax.Types.noop { });
            if (UseTestNet) req.account = TestNetContractName;
            var result = await Execute(api, req);
            if (result.error)
            {
                Console.WriteLine($"Error: {result.result}");
                Environment.Exit(10);
            }
            else
            {
                Console.WriteLine($"Transaction executed: {result.tx}");
            }
        }
    }
}