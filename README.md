# OXO Chain

OXO Chain is an Ethereum-based PoA blockchain. 
OXO Chain uses the Proof-of-Authority consensus.

## Websites

|SiteName|URL|
|--|--|
|Main Web|https://oxochain.com|
|Block Explorer|https://explorer.oxochain.com/dashboard|
|Node Stats|http://stats.oxochain.com|

| P2P Nodes                                                    |
| ------------------------------------------------------------ |
| enode://351f3a5213cebaff66a5a7a786811ddcb42d40ceae7cdc1a3299c5f13b20af1ebea38caff4a09dc40f776660ed42bac33b7976ab627792f845f7661b76fee6b5@31.210.159.189:30303 |
| enode://5818e349b71a1686307642d34335c8714d1beb2f521294f810f24f0d0d931c0756846eb3622555c4c0f84fea79efd80dcda06ad9fb9922d55eea4126012a54f9@31.210.159.189:31881 |
| enode://b51d6e52cf78b46caab9cfdf3a60cb7b4a63603b7f70151a9b1d05d8dba6b45034db159bc0334e21289b98fc6937730c251c4b9f53e2b02c56b15f09d437b9ef@31.210.159.190:31881 |
| enode://d2db5965396b2179127c9019ea6fbb1db82c90d72b85d2359d77d9769391cd44916769cdfe49a296d575c9da203c47904c3105b0512e3d55cdc648bfe995d4f7@95.216.106.234:31881 |
| enode://5fd6789f035d62e4f4c16989b2b6fa57404ae7e961fff0d1ea29296d42a1e34b098056a1005d245830a6d2c4565337496c05df08a00ac1e765081f154be87cab@178.79.173.74:31881 |
| enode://d8a697df373c6b163a187c468f9047f9197183ce94159448474905dd7504b988d2d2ddf35dbea0a791a2234a83336e886ec84c9514b69f4bcc2b03fa23e73809@152.228.180.128:31881 |
| enode://e81abf478bedec8f8254c5c5479aff0ae36bfc311c5e6476e55d637f8ab22b1a5bf8acd4b64cdfa8e14a634df375d5940f38d2563f1f38fe27771379b915f11a@176.31.72.208:31881 |
| enode://422efff15b7214a5a99a858215c01a02b75f14d7767548055d2dc62081d732fbe8a21638c776ad5ce0287c2218776df2e3bcd360e5e0e9979efabf5f5c0612d3@37.247.100.12:31881 |


## Authority WalletIDs

|WalletID |Owner |
|--|--|
| 0xd999f6a3882954983Dc94A20425C198d29E00000| OXOChain Team |

## PreBalanced WalletIDs

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

## Popular token contract addresses

|Token|Name|Contract Address  |Total Supply|*
|--|--|--|--|--|
|PUAN|Puan Token|0x32D3BAF80049578D143Aa78d33De027816979f12|100.000.000|Mintable/Burnable|

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

