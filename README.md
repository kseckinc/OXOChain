# OXO Chain

OXO Chain is an Ethereum-based PoA blockchain. 
OXO Chain uses the Proof-of-Authority consensus.

## Websites

|SiteName|URL|
|--|--|
|Main Web|https://oxochain.com|
|Block Explorer|https://explorer.oxochain.com|
|Testnet Block Explorer|https://explorer.testnet.oxochain.com |
|Node Stats|http://stats.oxochain.com|

| BootNodes |
|--|
| enode://098599002489e8d4acc26d6d04cc5fb02b7f54fd5de69f52fed8473df66139b66d8395938f46c6c913bb4bc26f39029144d4ea992e3ba8927272be2f663142f8@31.210.159.190:31881 |
| enode://5abf3991db498061b72b6d5b3cb90fb8ee10d37bca377cb3b3f11b4f481d90afc3f3ceb7ee1ef43cfacdb6f450f2ef37a8ad08b10b4f9d04fd25a3f24d9a2de7@31.210.159.189:11881 |
| enode://8b9ec01abc2cbf9f562cc92023bee3bfad0786301948d576372d9ae7c66a567fcc530c90e0221da5898f049cf3f176ec474887eb04276a10aebb532f49d6e551@31.210.159.190:11881 |
| enode://c699009eddb31e5be2259d3e25f459ccd60425fa275aa00f908f0ca7230574953a5333ca1d46a198cfcab20d80d00b5087ec50a6a9e18eab2d2b77a5867bf7c7@95.216.106.234:11881 |

| Other Nodes |
|--|
| enode://2c62fec9b397cd7a93ad62953021a4ac77876e9a39aac1743a522e96bf05a7b02a028426bd477fbae681281ad5a0bb270b062f2b258d37a2c7286d3c1320ec71@31.210.159.189:21881 |
| enode://daec7f9ba445a0980501269a31110afd1b685dce87ba4b8ab946c24f39c4e329d5bb707af8a0e38b085ae88a6f7f62851bf619d4fa30cbf6afdf10a4a7fbd456@176.31.72.208:31881 |
| enode://da3efcf66e73653418bf5bce2f6fa9561965b28435317bc88eefb5021dd0565aaf90a9eeec0dafbb3097a64ed34fc5b9011f2b19ee924a5cd8c5505271df76bb@37.247.100.12:31881 |
| enode://f813cc1a321dd0d585ca3bc33b9dc5dab29d5e06a5907066ba71d8da7c9f84807e0aed65564578e78a6a62b53048b87db28780d18a4c34401bf3b444ee25e0ff@152.228.180.128:31881 |
| enode://61d16fd0072dca5c204bdd11835e6fad566538fdf69c351152398086a876ab03683871ba7a853e5cbe1f249b5204388277513dde0d5d006af6e4a5cb220ee18b@95.216.106.237:31881 |

## Validators

|WalletID |Owner |
|--|--|
| 0xd999f6a3882954983Dc94A20425C198d29E00000| OXOChain Team |
| 0x16DC29E718C0da149D71cc4B44B130571F500000| OXOChain Foundation |
| 0x91a5930D54598EA7fC1505f19e331D05D4000000| Blockchain University |
| 0x0000000000000000000000000000000000000000| DGN Teknoloji |
| 0x0000000000000000000000000000000000000000| Netinternet Bilişim Teknolojileri |



## PreBalanced WalletIDs (starting)

|WalletID |StartBalance  |
|--|--|
| 0xebf3E7512C9255bD1130DcdE783bC6365E300000|  500.000.000 OXO|


## For Metamask/PocketToken

You can use it with an RPC connection with a wallet such as Metamask. 

||Detail|
|--|--|
| RPC|  https://rpc.oxochain.com|
| ChainID |  1881|
| Symbol|  OXO|

#### TestNet

||Detail|
|--|--|
| RPC|  https://rpc.testnet.oxochain.com|
| ChainID |  91881|
| Symbol|  TOXO|

## Popular token contract addresses

|Token|Name|Contract Address  |Total Supply|*
|--|--|--|--|--|
|TEST|Test Token|0xD76b991152060b686F6daCC2923f53c7Fc48Da09|1.000.000|Mintable/Burnable|

## genesis.json

```json
{
  "config": {
    "chainId": 1881,
    "homesteadBlock": 0,
    "eip150Block": 0,
    "eip150Hash": "0x0000000000000000000000000000000000000000000000000000000000000000",
    "eip155Block": 0,
    "eip158Block": 0,
    "byzantiumBlock": 0,
    "constantinopleBlock": 0,
    "petersburgBlock": 0,
    "istanbulBlock": 0,
    "clique": {
      "period": 15,
      "epoch": 30000
    }
  },
  "nonce": "0x0",
  "timestamp": "0x617970b3",
  "extraData": "0x0000000000000000000000000000000000000000000000000000000000000000d999f6a3882954983dc94a20425c198d29e000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
  "gasLimit": "0x47b760",
  "difficulty": "0x1",
  "mixHash": "0x0000000000000000000000000000000000000000000000000000000000000000",
  "coinbase": "0x0000000000000000000000000000000000000000",
  "alloc": {
    "ebf3e7512c9255bd1130dcde783bc6365e300000": {
      "balance": "500000000000000000000000000"
    }
  },
  "number": "0x0",
  "gasUsed": "0x0",
  "parentHash": "0x0000000000000000000000000000000000000000000000000000000000000000",
  "baseFeePerGas": null
}


```

