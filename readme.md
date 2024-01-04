![Lumpi-Nick](https://rp.naw.io/img/lumpinick.png)
# ValidateWaxPK

This is a Proof of Concept program to test a private key for the [Wax](https://wax.io/) Blockchain using [C#](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2022) am using the [ABI2CSharp](https://github.com/NKCSS/ABI2CSharp) and [EosSharp](https://github.com/NKCSS/eos-sharp) projects.

Today, [TD](https://twitter.com/TrentDavis78) from [NFTGamerTV](https://www.twitch.tv/nftgamertv) had an issue with a private key that would not load when he tried to add it to his Anchor wallet. I suggested trying to test the key 'raw' to execute a simple no-op on the Wax chain. To do this, we used [ABI2CSharp](https://github.com/NKCSS/ABI2CSharp) and a small Console Application. This is that basic idea, al be it a bit cleaned up 😊

## Examples

Literal key supplied, followed by wallet name 'walletname' to execute against testnet:

```csharp
ValidateWaxPK.exe pk:5..total_of_51_characters walletname testnet
```

Private key exists in file "C:\keys\test.pk" for wallet testtesttest on Wax MainNet:

```csharp
ValidateWaxPK.exe "C:\keys\test.pk" testtesttest
```