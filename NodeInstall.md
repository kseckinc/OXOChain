# Node Setup on Ubuntu 20.04 LTS

---

## SimpleSetup
```shell
wget https://github.com/OXOChain/OXOChain/raw/main/OxoNodeInstall --no-cache
chmod +x OxoNodeInstall
./OxoNodeInstall
```

Run and check outputs
```shell
./node.sh
tail -f nohup.out
```

----

### apt update/upgrade etc

```shell
sudo apt-get update -y && apt upgrade -y && apt autoremove -y
sudo apt-get install -y software-properties-common
```

### Install Ethereum GO Client (geth)

```shell
sudo add-apt-repository -y ppa:ethereum/ethereum
sudo apt-get -y update
sudo apt-get -y install ethereum
```

### Create oxonode folder

```shell
mkdir oxonode && cd oxonode
```
----
## FOR RPC FULL NODE

### Set Parameters

```shell
NODEIP=...
NODENAME=...
PASSWORD=...
NETWORKID=1881
NODEPORT=31881
WSPORT=18546
RPCPORT=18545
STATSPASSWORD=gazete
BOOTNODES=enode://098599002489e8d4acc26d6d04cc5fb02b7f54fd5de69f52fed8473df66139b66d8395938f46c6c913bb4bc26f39029144d4ea992e3ba8927272be2f663142f8@31.210.159.190:31881,enode://5abf3991db498061b72b6d5b3cb90fb8ee10d37bca377cb3b3f11b4f481d90afc3f3ceb7ee1ef43cfacdb6f450f2ef37a8ad08b10b4f9d04fd25a3f24d9a2de7@31.210.159.189:11881,enode://8b9ec01abc2cbf9f562cc92023bee3bfad0786301948d576372d9ae7c66a567fcc530c90e0221da5898f049cf3f176ec474887eb04276a10aebb532f49d6e551@31.210.159.190:11881,enode://c699009eddb31e5be2259d3e25f459ccd60425fa275aa00f908f0ca7230574953a5333ca1d46a198cfcab20d80d00b5087ec50a6a9e18eab2d2b77a5867bf7c7@95.216.106.234:11881
```

### CREATE password.txt 

```shell
rm password.txt

cat >> password.txt << EOF
$PASSWORD
EOF
```

### Create new wallet with password

```shell
geth --datadir . account new --password password.txt
```

### Download oxochain.json Genesis File

```shell
wget https://raw.githubusercontent.com/OXOChain/OXOChain/main/oxochain.json -O oxochain.json
```

### init oxochain.json and create-execute node.sh

```shell
rm -rf geth/ && rm -rf nohup.out
geth --datadir . init oxochain.json
rm -rf node.sh
cat >> node.sh << EOF
nohup geth --networkid $NETWORKID --datadir "." --syncmode "full" --port $NODEPORT --bootnodes "$BOOTNODES" --allow-insecure-unlock --unlock 0 --password password.txt --http.vhosts "*" --http.corsdomain "*" --ethstats $NODENAME:$STATSPASSWORD@stats.oxochain.com:443 --http --http.addr "$NODEIP" --http.port $RPCPORT --http.api admin,eth,miner,web3,net,personal,txpool,clique,debug --ws --ws.port $WSPORT --ws.api admin,eth,miner,web3,net,personal,txpool,debug --ws.addr "$NODEIP" --gcmode "archive" --cache 1024  &
EOF
chmod +x node.sh
./node.sh
tail -f nohup.out | grep enode: 
```
----

## FOR SIGNER NODE 

### Set Parameters
```shell
SIGNERWALLET=...
SIGNERPRIVATE=... // don't forget clear history after setup
NODENAME=...
PASSWORD=...
NETWORKID=1881
NODEPORT=31881
STATSPASSWORD=gazete
BOOTNODES=enode://098599002489e8d4acc26d6d04cc5fb02b7f54fd5de69f52fed8473df66139b66d8395938f46c6c913bb4bc26f39029144d4ea992e3ba8927272be2f663142f8@31.210.159.190:31881,enode://5abf3991db498061b72b6d5b3cb90fb8ee10d37bca377cb3b3f11b4f481d90afc3f3ceb7ee1ef43cfacdb6f450f2ef37a8ad08b10b4f9d04fd25a3f24d9a2de7@31.210.159.189:11881,enode://8b9ec01abc2cbf9f562cc92023bee3bfad0786301948d576372d9ae7c66a567fcc530c90e0221da5898f049cf3f176ec474887eb04276a10aebb532f49d6e551@31.210.159.190:11881,enode://c699009eddb31e5be2259d3e25f459ccd60425fa275aa00f908f0ca7230574953a5333ca1d46a198cfcab20d80d00b5087ec50a6a9e18eab2d2b77a5867bf7c7@95.216.106.234:11881
```

### Create password.txt and p.txt (private key)
```shell
rm password.txt && rm p.txt

cat >> password.txt << EOF
$PASSWORD
EOF

cat >> p.txt << EOF
$SIGNERPRIVATE
EOF
```

### Create wallet file from private key with password
```shell
geth --datadir . account import p.txt --password password.txt && rm p.txt
```

### Download oxochain.json Genesis File
```shell
wget https://raw.githubusercontent.com/OXOChain/OXOChain/main/oxochain.json -O oxochain.json
```

### init oxochain.json and create-execute node.sh
```shell
rm -rf geth/ && rm -rf nohup.out
geth --datadir . init oxochain.json
rm -rf node.sh
cat >> node.sh << EOF
nohup geth --networkid $NETWORKID --datadir "." --syncmode "full" --port $NODEPORT --bootnodes "$BOOTNODES" --allow-insecure-unlock --unlock "$SIGNERWALLET" --password password.txt --http.vhosts "*" --http.corsdomain "*" --ethstats $NODENAME:$STATSPASSWORD@stats.oxochain.com:443 --mine --miner.gastarget 7500000 --miner.gaslimit 120000000 --miner.gasprice 1000000000 --miner.etherbase "$SIGNERWALLET" --miner.extradata "$NODENAME" &  &
EOF
chmod +x node.sh
./node.sh
tail -f nohup.out | grep enode:
```

----

## connect geth.ipc and add peers

```shell
geth attach geth.ipc

admin.addPeer("enode://098599002489e8d4acc26d6d04cc5fb02b7f54fd5de69f52fed8473df66139b66d8395938f46c6c913bb4bc26f39029144d4ea992e3ba8927272be2f663142f8@31.210.159.190:31881")
admin.addPeer("enode://5abf3991db498061b72b6d5b3cb90fb8ee10d37bca377cb3b3f11b4f481d90afc3f3ceb7ee1ef43cfacdb6f450f2ef37a8ad08b10b4f9d04fd25a3f24d9a2de7@31.210.159.189:11881")
admin.addPeer("enode://8b9ec01abc2cbf9f562cc92023bee3bfad0786301948d576372d9ae7c66a567fcc530c90e0221da5898f049cf3f176ec474887eb04276a10aebb532f49d6e551@31.210.159.190:11881")
admin.addPeer("enode://c699009eddb31e5be2259d3e25f459ccd60425fa275aa00f908f0ca7230574953a5333ca1d46a198cfcab20d80d00b5087ec50a6a9e18eab2d2b77a5867bf7c7@95.216.106.234:11881")
```
