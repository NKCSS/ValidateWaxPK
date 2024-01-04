// Auto Generated, do not edit.
using System.Globalization;
using System.IO;
using System.Text;
using Abi2CSharp.Model.eosio;
using Cryptography.ECDSA; // add nuget package Cryptography.ECDSA.Secp256K1
using EosSharp;
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using System.Net.Http;
using System.Linq;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Abi2CSharp
{
    public static partial class Contracts
    {
        public static partial class boost_wax
        {
            public const string contract = "boost.wax";
            public static class Actions
            {
                public const string boost = nameof(boost);
                public const string boosterdel = nameof(boosterdel);
                public const string dereg = nameof(dereg);
                public const string noop = nameof(noop);
                public const string reg = nameof(reg);
                public const string unboost = nameof(unboost);
                public const string updateboost = nameof(updateboost);
            }
            public static class Tables
            {
                // Rows are of type boosters. If you want helper code generated, enable includeEosSharpTest
                public static class boosters
                {
                    public const string TableName = "boosters";
                    public static Task<GetTableRowsResponse<Types.boosters>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.boosters>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.boost_wax.contract,
                            scope = scope ?? Contracts.boost_wax.contract,
                            table = Contracts.boost_wax.Tables.boosters.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type boosts. If you want helper code generated, enable includeEosSharpTest
                public static class boosts
                {
                    public const string TableName = "boosts";
                    public static Task<GetTableRowsResponse<Types.boosts>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.boosts>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.boost_wax.contract,
                            scope = scope ?? Contracts.boost_wax.contract,
                            table = Contracts.boost_wax.Tables.boosts.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type contracts. If you want helper code generated, enable includeEosSharpTest
                public static class contracts
                {
                    public const string TableName = "contracts";
                    public static Task<GetTableRowsResponse<Types.contracts>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.contracts>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.boost_wax.contract,
                            scope = scope ?? Contracts.boost_wax.contract,
                            table = Contracts.boost_wax.Tables.contracts.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
            }
            public static partial class Types
            {
                public partial class boost {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name to  { get; set; }
                    public Model.eosio.Asset cpu  { get; set; }
                    public Model.eosio.Asset net  { get; set; }
                }
                public partial class boosterdel {
                    public Model.eosio.Name booster  { get; set; }
                }
                public partial class boosters {
                    public Model.eosio.Name booster  { get; set; }
                }
                public partial class boosts {
                    public Model.eosio.Name user  { get; set; }
                    public Model.eosio.Name requester  { get; set; }
                    public Model.eosio.Asset amount_cpu  { get; set; }
                    public Model.eosio.Asset amount_net  { get; set; }
                    public ulong time  { get; set; }
                }
                public partial class contracts {
                    public Model.eosio.Name contract  { get; set; }
                    public ulong cpu_us_per_user  { get; set; }
                    public ulong net_words_per_user  { get; set; }
                    public bool use_allow_list  { get; set; }
                    public Model.eosio.Name[] allowed_contracts  { get; set; }
                }
                public partial class dereg {
                    public Model.eosio.Name contract  { get; set; }
                }
                public partial class noop {
                }
                public partial class reg {
                    public Model.eosio.Name contract  { get; set; }
                    public ulong cpu_us_per_user  { get; set; }
                    public ulong net_words_per_user  { get; set; }
                    public bool use_allow_list  { get; set; }
                    public Model.eosio.Name[] allowed_contracts  { get; set; }
                }
                public partial class unboost {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name to  { get; set; }
                }
                public partial class updateboost {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name to  { get; set; }
                    public Model.eosio.Asset cpu_to  { get; set; }
                    public Model.eosio.Asset net_to  { get; set; }
                }
            }
            public static class Requests
            {
                const string DefaultPermission = "active";
                public class boost : Types.boost
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.boost data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.boost data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.boost,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class boosterdel : Types.boosterdel
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.boosterdel data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.boosterdel data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.boosterdel,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class dereg : Types.dereg
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.dereg data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.dereg data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.dereg,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class noop : Types.noop
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.noop data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.noop data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.noop,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class reg : Types.reg
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.reg data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.reg data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.reg,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class unboost : Types.unboost
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unboost data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unboost data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.unboost,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class updateboost : Types.updateboost
                {
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updateboost data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updateboost data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = boost_wax.contract,
                            name = Actions.updateboost,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
            }
            public static class Responses
            {
                public class boosters : Types.boosters
                {
                }
                public class boosts : Types.boosts
                {
                }
                public class contracts : Types.contracts
                {
                }
            }
        }
    }
    public static class Extensions
    {
        const char NULL = '\0';
        const int BitsPerByte = 8;
        const int BytesPer256Bits = 256 / BitsPerByte;        
        const int Zero = (int)'0';
        const int HexAFOffset = 10;
        const int UpperCaseA = (int)'A';
        const int UpperCaseAOffset = UpperCaseA - HexAFOffset;
        const int LowerCaseA = (int)'a';
        const int LowerCaseAOffset = LowerCaseA - HexAFOffset;
        #region Name-based constants
        const int NameMaxCharLength = 13;
        /// <summary>
        /// The amount of bits an Antelope name is encoded into.
        /// </summary>
        const int NameBitLength = 64;
        /// <summary>
        /// The amount of bits we can use per character.
        /// </summary>
        const int BitsPerNameValue = 5;
        /// <summary>
        /// The amount of charcters that can use the full bit length we need (12)
        /// </summary>
        const int NameFullBitCharCount = NameBitLength / BitsPerNameValue;
        /// <summary>
        /// The amount of bits that can have the full-length (60 in our case)
        /// </summary>
        const int NameBitsWithFullBitLength = NameFullBitCharCount * BitsPerNameValue;
        /// <summary>
        /// The amount of bits that remain for the last value (4)
        /// </summary>
        const int NameRestBits = NameBitLength - NameBitsWithFullBitLength;
        /// <summary>
        /// The last bit index that has <see cref="BitsPerNameValue"/> bits per encoded character.
        /// </summary>
        /// <remarks>
        /// Indexes are 0-based, so we take the amount of bits that are full-length values and substract 1.
        /// </remarks>
        const int LastFullLengthNameBitIndex = NameBitsWithFullBitLength - 1;
        /// <summary>
        /// The bitmask we use to extract the bits from the value. We shift by the bit length (e.g. overshoot), 
        /// then substract 1 to get a full set of binary 1 flags for our desired bit length.
        /// </summary>
        const int NameValueBitMask = (1 << BitsPerNameValue) - 1;
        /// <summary>
        /// The bitmask we use to extract the bits from the value. We shift by the bit length (e.g. overshoot), 
        /// then substract 1 to get a full set of binary 1 flags for our desired bit length.
        /// </summary>
        const int NameRestBitMask = (1 << NameRestBits) - 1;
        #endregion
        static Dictionary<char, byte> CharByteLookup;
        static Dictionary<byte, char> ByteCharLookup;
        static Extensions()
        {
            CharByteLookup = new Dictionary<char, byte>();
            ByteCharLookup = new Dictionary<byte, char>();
            CharByteLookup.Add('.', 0);
            ByteCharLookup.Add(0, '.');
            for (byte i = 1; i <= 5; ++i)
            {
                CharByteLookup.Add(i.ToString()[0], i);
                ByteCharLookup.Add(i, i.ToString()[0]);
            }
            byte offset = 'a' - 6;
            for (char c = 'a'; c <= 'z'; ++c)
            {
                CharByteLookup.Add(c, (byte)((byte)c - offset));
                ByteCharLookup.Add((byte)((byte)c - offset), c);
            }
        }
        public static string ReadEosioString(this BinaryReader br) => System.Text.Encoding.UTF8.GetString(br.ReadBytes(br.DecodeInt32()));
        public static string ToName(this ulong value)
        {
            char[] result = new char[NameMaxCharLength];
            byte v;
            char c;
            int resultIndex = 0;
            // The first 60 bits are 5-bits per value; 
            for (int i = 0; i < NameBitsWithFullBitLength; i += BitsPerNameValue)
            {
                v = (byte)((value >> LastFullLengthNameBitIndex - i) & NameValueBitMask);
                c = ByteCharLookup[v];
                result[resultIndex++] = c;
            }
            v = (byte)(value & NameRestBitMask);
            c = ByteCharLookup[v];
            result[resultIndex] = c;
            // Strip any trailing 0-values (e.g. '.')
            return new string(result).TrimEnd(ByteCharLookup[0]);
        }
        public static ulong NameToLong(this string name)
        {
            if ((name?.Length ?? 0) > NameMaxCharLength) throw new ArgumentException($"'{name}' (len: {name.Length}) exceeds the name character limit, which is {NameMaxCharLength}", nameof(name));
            ulong result = 0L;
            int bitIndex = 0, i;
            byte c;
            // Process the full-bit-length characters
            for (i = 0; i < NameFullBitCharCount; i++)
            {
                c = i < name.Length ? CharByteLookup[name[i]] : (byte)0;
                if ((c & 0b00001) == 0b00001) result += 1UL << (59 - bitIndex);
                if ((c & 0b00010) == 0b00010) result += 1UL << (60 - bitIndex);
                if ((c & 0b00100) == 0b00100) result += 1UL << (61 - bitIndex);
                if ((c & 0b01000) == 0b01000) result += 1UL << (62 - bitIndex);
                if ((c & 0b10000) == 0b10000) result += 1UL << (63 - bitIndex);
                bitIndex += 5;
            }
            // Process the last 4 bits
            c = i < name.Length ? CharByteLookup[name[i]] : (byte)0;
            if ((c & 0b0001) == 0b0001) result += 1UL;
            if ((c & 0b0010) == 0b0010) result += 1UL << 1;
            if ((c & 0b0100) == 0b0100) result += 1UL << 2;
            if ((c & 0b1000) == 0b1000) result += 1UL << 3;
            return result;
        }
        public static int GetHexVal(this char hex)
        {
            int val = (int)hex;
            if (val < UpperCaseA)
                return val - Zero;
            else if (val < LowerCaseA)
                return val - UpperCaseAOffset;
            return
                val - LowerCaseAOffset;
        }
        public static byte[] ToByteArrayFastest(this string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");
            int byteCount = hex.Length >> 1;

            byte[] arr = new byte[byteCount];

            for (int i = 0; i < byteCount; ++i)
            {
                arr[i] = (byte)((hex[i << 1].GetHexVal() << 4) + hex[(i << 1) + 1].GetHexVal());
            }

            return arr;
        }
        public static string ToHexUpper(this byte[] value)
        {
            char[] result = new char[value.Length * 2];
            int index = 0;
            byte b;
            for (int ix = 0; ix < result.Length; ix += 2)
            {
                b = value[index++];
                result[ix] = GetHexUpper(b / 16);
                result[ix + 1] = GetHexUpper(b % 16);
            }
            return new string(result);
        }
        public static string ToHexLower(this byte[] value)
        {
            char[] result = new char[value.Length * 2];
            int index = 0;
            byte b;
            for (int ix = 0; ix < result.Length; ix += 2)
            {
                b = value[index++];
                result[ix] = GetHexLower(b / 16);
                result[ix + 1] = GetHexLower(b % 16);
            }
            return new string(result);
        }
        static char GetHexUpper(int i)
        {
            if (i < 0 || i > 15) throw new ArgumentException("Value must be between 0 and 15");
            else if (i < 10) return (char)(i + '0');
            return (char)(i - 10 + 'A');
        }
        static char GetHexLower(int i)
        {
            if (i < 0 || i > 15) throw new ArgumentException("Value must be between 0 and 15");
            else if (i < 10) return (char)(i + '0');
            return (char)(i - 10 + 'a');
        }
    }
    public static class VariableLengthInteger
    {
        const int BitsPerByte = 8;
        const int DataBits = BitsPerByte - 1;
        const int DataBitMask = (1 << DataBits) - 1;
        const int ContinuationBit = 1 << DataBits;
        public static void EncodeInt32(this BinaryWriter writer, int value)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be 0 or greater");
            foreach(byte val in value.EncodeInt32())
                writer.Write(val);
        }
        public static IEnumerable<byte> EncodeInt32(this uint value)
        {
            do
            {
                // Grab the lowest 7-bits of the value
                byte lower7bits = (byte)(value & DataBitMask);
                // Then shift the value by 7 and check if there is any value left.
                value >>= DataBits;
                if (value > 0) // If anything remains, ensure the continuation bit is set by OR-ing with 10000000 (1 + 7 bits from the data)
                    lower7bits |= ContinuationBit;
                yield return lower7bits;
            } while (value > 0);
        }
        public static IEnumerable<byte> EncodeInt32(this int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be 0 or greater");
            foreach(var b in EncodeInt32((uint)value)) 
                yield return b;
        }
        public static int DecodeInt32(this BinaryReader reader)
        {
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            bool more = true;
            int value = 0, shift = 0;
            while (more)
            {
                byte lower7bits = reader.ReadByte();
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
            }
            return value;
        }
        public static int DecodeInt32(this IEnumerable<byte> bytes, bool breakOnNoMore = false)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));
            bool more = true;
            int value = 0, shift = 0;
            foreach(byte lower7bits in bytes)
            {
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
                if (breakOnNoMore && !more) break;
            }
            if (more) throw new ArgumentException("Last byte still had the 'more' flag set!", nameof(bytes));
            return value;
        }
        public static int DecodeInt32(this MemoryStream ms)
        {
            if (ms == null) throw new ArgumentNullException(nameof(ms));
            bool more = true;
            int value = 0, shift = 0;
            while (more)
            {
                byte lower7bits = (byte)ms.ReadByte();
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
            }
            return value;
        }
    }    
    public class CustomJsonConverter<T>
        : JsonConverter
        where T : ICustomSerialize<T>
    {
        public override bool CanConvert(Type objectType) => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is ICustomSerialize<T> t) writer.WriteValue(t.Serialize());
        }
        public override bool CanRead { get => true; }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICustomSerialize<>)))
            {
                if ((existingValue ?? Activator.CreateInstance<T>()) is ICustomSerialize<T> t) return t.Deserialize(reader);
            }
            return null;
        }
    }
	namespace Model.eosio
	{
        public interface ICustomSerialize<T>
        {
            string Serialize();
            T Deserialize(JsonReader reader);
        }
        [JsonConverter(typeof(CustomJsonConverter<Asset>))]
	    public class Asset : ICustomSerialize<Asset>
	    {        
		    const string EnglishCultureName = "en-GB";
		    static readonly CultureInfo EnglishCulture = new CultureInfo(EnglishCultureName);
		    public Symbol Token { get; set; }
		    public UInt64 Balance { get; set; }
		    [Newtonsoft.Json.JsonIgnore]
		    public decimal BalanceDecimal { get => Balance / (decimal)Token.Factor; set => Balance = (ulong)(value * (decimal)Token.Factor); }
		    /// <remarks>
		    /// We use the F string format so there is only a decimal, no thousand separator.
		    /// </remarks>
		    public override string ToString() => $"{BalanceDecimal.ToString($"F{Token.precision}", EnglishCulture)} {Token.name}";
            public Asset() { } // Empty constructor for serializing
		    public Asset(Symbol token, UInt64 balance)
            {
			    Token = token;
			    Balance = balance;
            }
		    public static implicit operator Asset(string value)
		    {
			    Asset result = new Asset();
			    string[] parts = value.Split(' ');
			    if (parts.Length != 2) throw new ArgumentException($"Cannot parse '{value}' as a valid token balance", nameof(value));
			    string[] valueParts = parts[0].Split('.');
			    result.Token = new Symbol(
				    name: parts[1], 
				    precision: (byte)(valueParts.Length == 2 ? valueParts[1].Length : 0)
			    );
			    if (decimal.TryParse(parts[0], NumberStyles.AllowDecimalPoint, EnglishCulture, out decimal balance)) result.BalanceDecimal = balance;
			    else throw new ArgumentException($"Unable to parse '{parts[0]}' as a valid decimal");
			    return result;
		    }
		    public static implicit operator string(Asset value) => value.ToString();
		    public string Serialize() => ToString();
		    public Asset Deserialize(JsonReader reader) => (string)reader.Value;
		    public override int GetHashCode() => ToString().GetHashCode();
		    public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
		    public static Asset operator +(Asset a, Asset b)
            {
			    System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Token == b.Token, "Both assets need to be the same token!");
			    return new Asset(a.Token, a.Balance + b.Balance);
		    }
		    public static Asset operator -(Asset a, Asset b)
		    {
			    System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Token == b.Token, "Both assets need to be the same token!");
			    return new Asset(a.Token, a.Balance - b.Balance);
		    }
		    public static Asset operator *(Asset x, ulong multi)
			    => new Asset(x.Token, x.Balance * multi);
		    public static Asset operator /(Asset x, ulong multi)
		    {
			    System.Diagnostics.Contracts.Contract.Requires<DivideByZeroException>(multi > 0, "Cannot divide by zero");
			    return new Asset(x.Token, x.Balance / multi);
		    }
	    }        
        [JsonConverter(typeof(CustomJsonConverter<ExtendedAsset>))]
	    public class ExtendedAsset : ICustomSerialize<ExtendedAsset>
	    {	
		    public Asset Quantity { get; set; }
		    public Name Contract { get; set; }
		    public override string ToString() => $"{Quantity.ToString()}@{Contract}";
            public ExtendedAsset() { } // Empty constructor for serializing
		    public ExtendedAsset(Asset quantity, Name contract)
            {
			    Quantity = quantity;
			    Contract = contract;
            }
		    public static implicit operator ExtendedAsset(string value)
		    {
			    Asset result = new Asset();
			    string[] parts = value.Split('@');
			    if (parts.Length != 2) throw new ArgumentException($"Cannot parse '{value}' as a valid token balance", nameof(value));
			    return new ExtendedAsset(parts[0], parts[1]);
		    }
		    public static implicit operator string(ExtendedAsset value) => value.ToString();
		    public string Serialize() => ToString();
		    public ExtendedAsset Deserialize(JsonReader reader)
            {
                // Read Start object Token.
                reader.Read();
                reader.Read();
                Asset quantity = (string)reader.Value;
                reader.Read();
                reader.Read();
                Name contract = (string)reader.Value;
                reader.Read();
                return new ExtendedAsset(quantity, contract);
            }
		    public override int GetHashCode() => ToString().GetHashCode();
		    public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
		    public static ExtendedAsset operator +(ExtendedAsset a, ExtendedAsset b)
            {
			    System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Contract == b.Contract, "Both assets need to be the same contract!");
                System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Quantity.Token == b.Quantity.Token, "Both assets need to be the same token!");
                return new ExtendedAsset(a.Quantity + b.Quantity, a.Contract);
		    }
		    public static ExtendedAsset operator -(ExtendedAsset a, ExtendedAsset b)
            {
                System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Contract == b.Contract, "Both assets need to be the same contract!");
                System.Diagnostics.Contracts.Contract.Requires<ArgumentException>(a.Quantity.Token == b.Quantity.Token, "Both assets need to be the same token!");
                return new ExtendedAsset(a.Quantity - b.Quantity, a.Contract);
            }
		    public static ExtendedAsset operator *(ExtendedAsset x, ulong multi)
			    => new ExtendedAsset(x.Quantity * multi, x.Contract);
		    public static ExtendedAsset operator /(ExtendedAsset x, ulong multi)
		    {
			    System.Diagnostics.Contracts.Contract.Requires<DivideByZeroException>(multi > 0, "Cannot divide by zero");
			    return new ExtendedAsset(x.Quantity / multi, x.Contract);
		    }
	    }
        [JsonConverter(typeof(CustomJsonConverter<CheckSum256>))]
        public class CheckSum256 : ICustomSerialize<CheckSum256>
        {
            const int BitsPerByte = 8;
            const int HexCharsPerByte = 2;
            internal const int ExpectedLength = (256 / BitsPerByte) * 2;
            byte[] _Raw;
            string _AsString;
            public byte[] Raw
            {
                get => _Raw;
                set
                {
                    _Raw = value;
                    _AsString = value.ToHexLower();
                }
            }
            public string AsString
            {
                get => _AsString;
                set
                {
                    _AsString = value;
                    _Raw = value.ToByteArrayFastest();
                }
            }
            public CheckSum256() { } // Empty constructor for serializing
            public CheckSum256(string value)
            {
                AsString = value;
            }
            public static implicit operator CheckSum256(string value)
            {
                int valueLength = value?.Length ?? 0;
                if (valueLength != ExpectedLength) throw new System.ArgumentException($"A {nameof(CheckSum256)} should be {ExpectedLength} bytes in length. Supplied value byte length: {valueLength}", nameof(value));
                else return new CheckSum256(value);
            }
            public static implicit operator string(CheckSum256 value) => value.AsString;
            public override string ToString() => AsString;
            public string Serialize() => AsString;
            public CheckSum256 Deserialize(JsonReader reader) => (string)reader.Value;
            public override int GetHashCode() => AsString.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }
        [JsonConverter(typeof(CustomJsonConverter<Name>))]
        public class Name : ICustomSerialize<Name>
        {
            ulong _Value;
            string _Name;
            public ulong Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Name = value.ToName();
                    }
                } 
            }
            public string AsString { 
                get => _Name;
                set
                {
                    if(value != _Name)
                    {
                        _Name = value;
                        _Value = AsString.NameToLong();
                    }
                }
            }
            public Name() { } // Empty constructor for serializing
            public Name(string value)
            {
                AsString = value;
            }
            public Name(ulong value)
            {
                Value = value;
            }
            public static implicit operator ulong(Name value) => value.Value;
            public static implicit operator string (Name value) => value.AsString;
            public static implicit operator Name(ulong value) => new Name(value);
            public static implicit operator Name(string value) => new Name(value);
            public override string ToString() => AsString;
            public string Serialize() => AsString;
            public Name Deserialize(JsonReader reader) => (string)reader.Value;
            public override int GetHashCode() => AsString.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }        
	    [JsonConverter(typeof(CustomJsonConverter<Symbol>))]
	    public class Symbol : ICustomSerialize<Symbol>
	    {
		    const char Separator = ',';
            public byte precision { get; set; }
            public string name { get; set; }
		    /// <remarks>
		    /// <see cref="System.Math.Pow">System.Math.Pow(10, 0)</see> returns 1, 
		    /// otherwise, this should have been written with a <see cref="System.Math.Max"/>
		    /// </remarks>
		    [Newtonsoft.Json.JsonIgnore]
		    public double Factor { get => System.Math.Pow(10, precision); }
		    public Symbol() { } // Empty constructor for serializing
		    public Symbol(string name, byte precision) {
			    this.name = name;
			    this.precision = precision;
		    }
		    public static implicit operator Symbol(string value)
            {
			    string[] parts = value.Split(Separator);
			    if (parts.Length != 2) throw new System.ArgumentException($"Symbol should be precision, followed by name, separated by '{Separator}'", nameof(value));
			    else if (!byte.TryParse(parts[0], out byte precision)) throw new System.ArgumentException($"Can't parse '{parts[0]}' as precision", nameof(value));
			    else return new Symbol(parts[1], precision);
		    }
		    public static implicit operator string(Symbol value) => value.ToString();
		    public override string ToString() => $"{precision}{Separator}{name}";
		    public string Serialize() => ToString();
		    public Symbol Deserialize(JsonReader reader) => (string)reader.Value;
		    public override int GetHashCode() => ToString().GetHashCode();
		    public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
	    }
        [JsonConverter(typeof(CustomJsonConverter<TimePoint>))]
        public class TimePoint : ICustomSerialize<TimePoint>
        {
            ulong _Value;
            DateTime _Moment;
            public ulong Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Moment = DateTime.UnixEpoch.AddMilliseconds(value);
                    }
                } 
            }
            public DateTime Moment
            { 
                get => _Moment;
                set
                {
                    if(value != _Moment)
                    {
                        _Moment = value;
                        _Value = (ulong)value.Subtract(DateTime.UnixEpoch).TotalMilliseconds;
                    }
                }
            }
            public TimePoint() { } // Empty constructor for serializing
            public TimePoint(ulong value)
            {
                Value = value;
            }
            public TimePoint(string value)
            {
                Moment = DateTime.SpecifyKind(DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture), DateTimeKind.Utc);
            }
            public TimePoint(DateTime value)
            {
                Moment = value;
            }
            public static implicit operator ulong(TimePoint value) => value.Value;
            public static implicit operator DateTime(TimePoint value) => value.Moment;
            public static implicit operator TimePoint(ulong value) => new TimePoint(value);
            public static implicit operator TimePoint(DateTime value) => new TimePoint(value);
            public static implicit operator TimePoint(string value) => new TimePoint(value);
            public override string ToString() => Moment.ToString("yyyy-MM-dd HH:mm:ss.fff");
            public string Serialize() => Value.ToString();
            /// <summary>
            /// NewtonSoft already deserializes the DateTime string properly, so we just need to ensure we specify it's in UTC, but we also support ulong and raw string.
            /// </summary>
            /// <param name="reader"></param>
            /// <returns></returns>
            public TimePoint Deserialize(JsonReader reader)
            {
                if (reader.Value is DateTime t) return DateTime.SpecifyKind(t, DateTimeKind.Utc);
                else if (reader.Value is string s) return ulong.TryParse(s, out ulong v) ? new TimePoint(v) : new TimePoint(s);
                else throw new ArgumentException($"Cannot deserialize '{reader.Value}' as a {nameof(TimePoint)}");
            }
            public override int GetHashCode() => Moment.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }
        [JsonConverter(typeof(CustomJsonConverter<TimePointSec>))]
        public class TimePointSec : ICustomSerialize<TimePointSec>
        {
            uint _Value;
            DateTime _Moment;
            public uint Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Moment = DateTime.UnixEpoch.AddSeconds(value);
                    }
                } 
            }
            public DateTime Moment
            { 
                get => _Moment;
                set
                {
                    if(value != _Moment)
                    {
                        _Moment = value;
                        _Value = (uint)value.Subtract(DateTime.UnixEpoch).TotalSeconds;
                    }
                }
            }
            public TimePointSec() { } // Empty constructor for serializing
            public TimePointSec(uint value)
            {
                Value = value;
            }
            public TimePointSec(string value)
            {
                Moment = DateTime.SpecifyKind(DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture), DateTimeKind.Utc);
            }
            public TimePointSec(DateTime value)
            {
                Moment = value;
            }
            public static implicit operator uint(TimePointSec value) => value.Value;
            public static implicit operator DateTime(TimePointSec value) => value.Moment;
            public static implicit operator TimePointSec(uint value) => new TimePointSec(value);
            public static implicit operator TimePointSec(DateTime value) => new TimePointSec(value);
            public static implicit operator TimePointSec(string value) => new TimePointSec(value);
            public override string ToString() => Moment.ToString("yyyy-MM-dd HH:mm:ss.fff");

            public string Serialize() => Value.ToString();
            /// <summary>
            /// NewtonSoft already deserializes the DateTime string properly, so we just need to ensure we specify it's in UTC, but we also support ulong and raw string.
            /// </summary>
            /// <param name="reader"></param>
            /// <returns></returns>
            public TimePointSec Deserialize(JsonReader reader)
            {
                if (reader.Value is DateTime t) return DateTime.SpecifyKind(t, DateTimeKind.Utc);
                else if (reader.Value is string s) return uint.TryParse(s, out uint v) ? new TimePointSec(v) : new TimePointSec(s);
                else throw new ArgumentException($"Cannot deserialize '{reader.Value}' as a {nameof(TimePointSec)}");
            }
            public override int GetHashCode() => Moment.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }        
        public class PublicKey
        {
            const string NewKeyType = "K1";
            public const string NewPrefix = "PUB_" + NewKeyType + "_";
            public const string OldPrefix = "EOS";
            byte[] bytes, bytesNoCheckSum, checkSum, newCheckSum, oldCheckSum;
            string oldKey, newKey;
            public string OldKey { get => oldKey; }
            public string NewKey { get => newKey; }
            public PublicKey(string key) {
                if (key.StartsWith(NewPrefix)) bytes = Base58.Decode(key.Substring(NewPrefix.Length));
                else if (key.StartsWith(OldPrefix)) bytes = Base58.Decode(key.Substring(OldPrefix.Length));
                else throw new ArgumentException($"Unknown key prefix used in '{key}'", nameof(key));
                bytesNoCheckSum = bytes.Take(bytes.Length - 4).ToArray();
                checkSum = bytes.Skip(bytesNoCheckSum.Length).ToArray();
                oldCheckSum = Ripemd160Manager.GetHash(bytesNoCheckSum).Take(4).ToArray();
                newCheckSum = Ripemd160Manager.GetHash(bytesNoCheckSum.Concat(Encoding.UTF8.GetBytes(NewKeyType)).ToArray()).Take(4).ToArray();
                oldKey = $"{OldPrefix}{Base58.Encode(bytesNoCheckSum.Concat(oldCheckSum).ToArray())}";
                newKey = $"{NewPrefix}{Base58.Encode(bytesNoCheckSum.Concat(newCheckSum).ToArray())}";
                if (key != oldKey && key != newKey) throw new ArgumentException($"Supplied key doesn't match expected old or new style; is your checksum wrong? Old: {oldKey}, New: {newKey}", nameof(key));
            }
            public static implicit operator PublicKey(string value) => new PublicKey(value);
        }
	} 
    public static class Test
    {
        public static async Task Run()
        {
            var api = new EosApi(new EosConfigurator()
            {
                SignProvider = null,
                HttpEndpoint = "https://api.waxsweden.org",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            }, new HttpHandler());
            var result = await Contracts.boost_wax.Tables.boosters.Query(api);
            Console.WriteLine($"First row from {Contracts.boost_wax.Tables.boosters.TableName} table: {JsonConvert.SerializeObject(result.rows.FirstOrDefault())}");
        }
        public static void TestEosioTypeSerialization()
        {
            string raw, json;
            raw = "1.00000000 WAX";
            Model.eosio.Asset a = raw;
            json = JsonConvert.SerializeObject(a);
            var ad = JsonConvert.DeserializeObject<Model.eosio.Asset>(json);
            if (!a.Equals(ad)) throw new ApplicationException($"Values don't match: {a} Vs {ad} ('{raw}' serialized: {json})");
            raw = new string('a', CheckSum256.ExpectedLength);
            Model.eosio.CheckSum256 c = raw;
            json = JsonConvert.SerializeObject(c);
            var cd = JsonConvert.DeserializeObject<Model.eosio.CheckSum256>(json);
            if (!c.Equals(cd)) throw new ApplicationException($"Values don't match: {c} Vs {cd} ('{raw}' serialized: {json})");
            raw = "y3zra.wam";
            Model.eosio.Name n = raw;
            json = JsonConvert.SerializeObject(n);
            var nd = JsonConvert.DeserializeObject<Model.eosio.Name>(json);
            if (!n.Equals(nd)) throw new ApplicationException($"Values don't match: {n} Vs {nd} ('{raw}' serialized: {json})");
            raw = "8,WAX";
            Model.eosio.Symbol s = raw;
            json = JsonConvert.SerializeObject(s);
            var sd = JsonConvert.DeserializeObject<Model.eosio.Symbol>(json);
            if (!s.Equals(sd)) throw new ApplicationException($"Values don't match: {s} Vs {sd} ('{raw}' serialized: {json})");
            raw = "2022-10-21T13:19:59.000";
            Model.eosio.TimePoint t = raw;
            json = JsonConvert.SerializeObject(t);
            var td = JsonConvert.DeserializeObject<Model.eosio.TimePoint>(json);
            if (!t.Equals(td)) throw new ApplicationException($"Values don't match: {t} Vs {td} ('{raw}' serialized: {json})");
            // Reuse raw value
            Model.eosio.TimePointSec ts = raw;
            json = JsonConvert.SerializeObject(ts);
            var tsd = JsonConvert.DeserializeObject<Model.eosio.TimePointSec>(json);
            if (!ts.Equals(tsd)) throw new ApplicationException($"Values don't match: {ts} Vs {tsd} ('{raw}' serialized: {json})");
        }
    }
}