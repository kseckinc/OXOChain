# OXO Chain

OXO Chain is an Ethereum-based PoA blockchain. 
OXO Chain uses the Proof-of-Authority consensus.

## Websites

|SiteName|URL|
|--|--|
|Main Web|https://oxochain.com|
|Block Explorer|https://explorer.oxochain.com/dashboard|
|Node Stats|http://stats.oxochain.com|

| P2P Nodes |
| enode://4e1763366f28a4c16f06524f6e717ce4ec4779f4dd18b821fb7d14dfc396a9fa4f5bd842edb4c9908b441d09a43eec7ba63e136d7caabb2156456a28eed45bcb@31.210.159.190:31881 |
| enode://63b49604e08d63d9d4ecbbe9a99fe05f53718f1c07ca26b1e8df686788c7e1027475a5ed8de085542493d68a2fdd6d515a273866ce3db8197a1c602fe31245b9@31.210.159.189:11881 |
| enode://6658931f8bd5dfe74d951ab868ae88a116b7ff5fb8c9b272da5872326c251fdf9529763a3424a526ee4ede664ee8564641f05692ee0f5d5515199ffc1eaeb58d@31.210.159.190:11881 |
| enode://f860ce901201518fd14127a57db6dfea406282db1b851cf5cfb1272c5aeac5f529cbf42e609dfcdc10f03d226e93d965669860a34e2a4c301c7ad6d71ccb3758@176.31.72.208:31881 |
| enode://55a3df84e35df1d1707ddcfcd2ba82f2f36527929341aaa7e3dc80fd761278c1fb6c329e1d6ee7b8d62ed8b7c4f79577c162505ece12e30324ca2c6d57e322d0@37.247.100.12:31881 |
| enode://7d54f123b01aa257638b67984cb0abd97d292da4a22893b6d6936e845919cc701208dd28b41f377a80784bedf8ee0a728b826453cc8bece69954b92059ee217a@152.228.180.128:31881 |
| enode://132ae67a3a3f62647de32fb145339bf0541d054f6416927ef32987339cee01a257d5bc6642f42198798e5bc42319e17d94f4ddea746b4c834b11f5273c91133d@95.216.106.237:31881 |
| enode://76ea748536df61b9dde213c300ae2da14ec7970da3ed791dcec51dc93aaae72c165af731534f583264332d58129f201b512689c63a0ea8349c8509c7aafe1776@31.210.159.189:21881 |
| enode://4ea35411bfa6b6d3831be1df7136bbf11c700768b36523f9d55061ed6f6907b17155a7730fe604063f63b46fce8e5503d70b6c13ebeca6793b6b09bfbc9ad76a@95.216.106.234:31881 |

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

