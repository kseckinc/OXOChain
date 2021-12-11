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
| enode://fe0f75f8c2c4c9aa02e1f640ab8fd0559fff1be5a23f10e8ebb51def23cb12e0221bb7bf8619c6e3228a35f41cae9a2c4ccf02c01228347ff72eaae8b4a370fb@31.210.159.190:31881 |
| enode://b3d8e428b4b1cdff2540b9a1f5d5cc3531ec21dfd214d5b6fecf66b9f8aee9b238aa615e0d8b5368579a1e8f850d2c3ea5cc2ff0118f81da760c58e3b0ec8fc3@31.210.159.189:11881 |
| enode://bf187780f4221c7e86a4e711069b30af68592d5203bffbe6e7dff916d2ad2bab76d404f24acdb0f3b9de1a6267c1c15f12b5a371138b0ca464a8431c46196417@31.210.159.190:11881 |
| enode://dd2336da54422fb33f0151575391c567ec6862b31fd726cbcc5ad3ab2a2a365ed73a49de9617e85db52ef5c1451ba7ffc4a04b5df80d76350112131f34a1e703@176.31.72.208:31881 |
| enode://4e556de0d3981337e9e8c0892354e2ad3bde6969883287309005d1129ebb18e7843b26cafaacb9e433b799ee85d0e21df8769e930b97017f56bbe511f1847155@37.247.100.12:31881 |
| enode://4f6782a3b21b4541a743261c3a6f35098b03a13f71b0207a14a4eb4f09cf12572debe4f0f190b815ed3c244ab9ed0fd585b727b875e301a31010232aa8e86fd3@152.228.180.128:31881 |
| enode://7dba3dec1019d800388abbc0c7d3d3a8c8f47975818fa81c57f5611296bdfaba7d3ffb4c4f014c918da555a6c27daaf60d61b85288ca5ebfb221e8736f42530f@95.216.106.237:31881 |
| enode://89d0dae99ea58ff089f3eb32b56e236687f45c180e5739a2802710fbde3373bfd6992eb4040d8f9b6667c76f1c028cbae9a692af1c6f1ee35c453f70c56b7b92@31.210.159.189:21881 |
| enode://8fc1d8799e4c31cea1e247d9e99a39728bb69ff56c456247683ad2bcb6d54f3f6507d24f5f641e3f50a070c6ccd28412df7ab31d2ec2f1cb813bc69d0453e211@95.216.106.234:31881 |

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

