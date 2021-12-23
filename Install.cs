// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("OxoChain Node Install");
Console.WriteLine("-----------------------------");

Console.WriteLine("NodeName");
var nodeName = Console.ReadLine();
Random r = new Random();
if (nodeName == "") nodeName = "Node" + r.Next(100000,999999);
Console.WriteLine("NodeIp (127.0.0.1)");
var nodeIp = Console.ReadLine();
if (nodeIp == "") nodeIp = "127.0.0.1";
Console.WriteLine("WalletPassword (123456)");
var walletPassword = Console.ReadLine();
if (walletPassword == "") walletPassword = "123456";
Console.WriteLine("Outputs (yes/no)");
var writeOutputs = Console.ReadLine();
if (String.IsNullOrEmpty(writeOutputs)) writeOutputs = "yes";
if (writeOutputs.ToLower() != "no")
{
    writeOutputs = "yes";
}

try
{
    var output = "";

    Console.WriteLine("## apt-get update -y");
    output = RunCommand("apt-get", " update -y");
    if(writeOutputs=="yes") Console.WriteLine(output);

    Console.WriteLine("## apt-get upgrade -y");
    output = RunCommand("apt-get", " upgrade -y");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("## apt-get autoremove -y");
    output = RunCommand("apt-get", " autoremove -y");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("## apt-get install -y software-properties-common");
    output = RunCommand("apt-get", " install -y software-properties-common");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("## add-apt-repository -y ppa:ethereum/ethereum");
    output = RunCommand("add-apt-repository", " -y ppa:ethereum/ethereum");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("## apt-get -y update");
    output = RunCommand("apt-get", " -y update");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("## apt-get -y install ethereum");
    output = RunCommand("apt-get", " -y install ethereum");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("Genesis File Downloading...");
    output = RunCommand("wget", " https://raw.githubusercontent.com/OXOChain/OXOChain/main/oxochain.json -O oxochain.json");
    if (writeOutputs == "yes") Console.WriteLine(output);

    Console.WriteLine("Bootnodes Information Downloading...");
    output = RunCommand("wget", " https://raw.githubusercontent.com/OXOChain/OXOChain/main/bootnode.txt -O bootnodes.txt");
    if (writeOutputs == "yes") Console.WriteLine(output);

    string bootNodes = "";

    string path = @"" + "bootnodes.txt";
    if (File.Exists(path))
    {
        string readText = File.ReadAllText(path);
        bootNodes = readText.Replace("\n", "").Replace("\r", "");
        Console.WriteLine("BootNodes:");
        Console.WriteLine(bootNodes);
        Console.WriteLine();

    }

    path = @"" + "password.txt";
    if (File.Exists(path)) File.Delete(path);
    using StreamWriter sr = File.AppendText(path);
    sr.WriteLine(walletPassword);
    sr.Close();


    Console.WriteLine("## Creating a wallet with password");
    output = RunCommand("geth", " --datadir . account new --password password.txt");
    if (writeOutputs == "yes") Console.WriteLine(output);

    String pathNode = @"" + "node.sh";
    if (File.Exists(pathNode)) File.Delete(pathNode);
    using StreamWriter sr2 = File.AppendText(pathNode);
    var star = "*";
    var and = "&";
    sr2.WriteLine("nohup geth --networkid 1881 --datadir . --syncmode full --port 31881 --bootnodes \"" + bootNodes + "\" --allow-insecure-unlock --unlock 0 --password password.txt --http.vhosts  \"" + star + "\"  --http.corsdomain \"" + star +"\" --ethstats " + nodeName + ":gazete@stats.oxochain.com:443 --http --http.addr " + nodeIp + " --http.port 18545 --http.api admin,eth,miner,web3,net,personal,txpool,clique,debug --ws --ws.port 18546 --ws.api admin,eth,miner,web3,net,personal,txpool,debug --ws.addr " + nodeIp + "  --gcmode archive --cache 1024 " + and );
    sr2.Close();


    pathNode = @"" + "kill.sh";
    if (File.Exists(pathNode)) File.Delete(pathNode);
    using StreamWriter sr3 = File.AppendText(pathNode);
    sr3.WriteLine( @"ps axuwww | grep -i "+ nodeName +":gazete --exclude='grep' | awk '{print $2}' | xargs kill -9");
    sr2.Close();

    Console.WriteLine("## Init genesis");

    output = RunCommand("geth", " --datadir . init oxochain.json");
    if (writeOutputs == "yes") Console.WriteLine(output);

    RunCommand("chmod", " +x node.sh");
    RunCommand("chmod", " +x kill.sh");
    
    //output = RunCommand("sh", " node.sh");
    //Console.WriteLine(output);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("START NODE: ./node.sh");
    Console.WriteLine(" STOP NODE: ./kill.sh");

}
catch (Exception)
{

    throw;
}



string RunCommand(string command, string args)
{
    var process = new Process()
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        }
    };
    process.Start();
    string output = process.StandardOutput.ReadToEnd();
    string error = process.StandardError.ReadToEnd();
    process.WaitForExit();

    if (string.IsNullOrEmpty(error)) { return output; }
    else { return error; }
}
