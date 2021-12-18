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
| enode://18d4deaf3e717b6c3db4e461e9df2902f81a5e5eb48ff510c1ed798270f9e5eb32d30e78d260a804af78a78132721178a33a2dae5236b1e59da8b8f3c163296d@31.210.159.190:31881 |
| enode://cd67229f5a51ebff2a4e9ab972fdbcad584ae50e84ac3cb185e29ef04c8e67f7c307108597f9d2a06d09cf0b7b91c156ab3bf957f92cdcc8ae2218546502dd4d@31.210.159.189:11881 |
| enode://cac694606e522cdbb878cd6e2245a51e3b26c29602a5c8adf1f34f1bfc580f5bed3303eec6378a3ab6c980d623263db59678776d6f9ab9dab56d5e252c5b07c1@31.210.159.190:11881 |
| enode://a400b743f93bb509fed49f032af50d7ae052b895024b05f3c828d2a538b0109caaac4ed5a29ca5617e44ac01a45d6e046d59845ef47a5cdb58ea411bfbb57351@176.31.72.208:31881 |
| enode://071a279adeca24cbf8e26395039827f91071f21a2462068657ce242863a350fd3edeea65724b158a51c0b9b8215ae6050fc9a67c525ec315404fb499936114e5@37.247.100.12:31881 |
| enode://9d620943d4a06bbb09e23a75d98997a4a921d6c3d3b0b52ece456e52b4798e8278a4827bc1cdda4d206e4acf157b1fbaffb4365a13dd0bc28dff007cad0cf499@152.228.180.128:31881 |
| enode://81960e5deb96f5cdbd45bea40ca042bf0937326cae599b8fe40f985c683d0f69fef04029a55e95897528890ccf956a85c17a5b6418cbccf595f036c685064537@95.216.106.237:31881 |
| enode://be9d295da989d71699ef8741a987bd6ab1db5b1f950c0466457585fcde35fa68675a27d6cd6ce4c948e183bc728ad56622fa7dff1ca7d53edb990a1d1067ab30@31.210.159.189:21881 |
| enode://d00a5e4cca3729c2f319e55cdb3b35dd9f926f9ff6dfd9f38388a036a2d6cdda59fe40d80ce9c0a0aad799052f14f5f69c597b7795505432d8520c25c189bee4@95.216.106.234:31881 |

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
|TEST|Test Token|0xdb0d8213b0Ae26A56026E53C10dF1D2F9Bd7330B|1.000.000|Mintable/Burnable|

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

