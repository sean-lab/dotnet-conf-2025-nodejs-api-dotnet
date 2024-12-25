function logToDotnetConsole() {
    const dotnet = require('node-api-dotnet/net8.0');
    const Console = dotnet.System.Console;
    Console.WriteLine('Hello .NET from Node.js!');
}

logToDotnetConsole();
