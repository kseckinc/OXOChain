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
| enode://8197a188e53ec330fb815ea35efef88df4245bdabca0ac78d7a7d9abee9b91aeaa937a5a6dacf03fcbbda57046816e8e8e2595de525ee326d909ab43deeb86bc@31.210.159.190:31881 |
| enode://3c84b78323b826d9d4df4bc35959810211a680ee292cc49f5ca1f1e8fc532c8f49f706d74e18bd189bde0ae7aadd5327d8f19521240393312fb300ba122ea767@31.210.159.189:11881 |
| enode://0d70705da21291b685540d41f56dcd09abdda59e8e16b7ea4ce5e80291cdfdc0467f1728463cc06ac531c5071f8abe3b3fff63c842ad27be09f065516e19c597@31.210.159.190:11881 |
| enode://34795445154fe5371ab229455f58f4b5c25b426eb176853b25401714e3a2ae689f63a8d89edf8e755ff268317fc6a6c1dec6d1e1b73b0f68fcbe29a649ccf44d@176.31.72.208:31881 |
| enode://4e83ab1f27339326cf9c75dc37aa823dd944c3eebca612655a7592a8037c86dba9ebeebe381078ce01645a005357594d467595f53e3b5d4a6df58a307e3d45f5@37.247.100.12:31881 |
| enode://c645a62aea1a4d3c4f62f58876d4f6a7f05c3f2d2b4eef3fa073d5f8d51ae273d42e77b9849f5a45fdd28a2d07d2cf84832caf563ab1a9b47f263b808a24b4f8@152.228.180.128:31881 |
| enode://0afb777ff96c87bb73f4eb40f4373c6b9d0c700366f5295285852fdd7bcb24a7e6d55f2bf894671a16055a09c291247c89150fc5f0e6e5df3049545451abdef9@95.216.106.237:31881 |
| enode://3cdd3bf946bdf48642b40bfe1283f0c7f152de74f69b71bbaec24551baafc13e7d7c2e17b0e3d638a94e23eea02b5328c0ba28739976291784a68a52b7ecebd0@31.210.159.189:21881 |
| enode://9b0022c4e6d19c3a322c6ec7f91ecc678de90a3e128dae08ebf0df254c5c24bae854be1bba0ece886578049781dc281577185559897f35eed94f62abf986ed6c@95.216.106.234:31881 |


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

