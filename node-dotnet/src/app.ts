import dotnet from 'node-api-dotnet';

async function main() {
    const dotnet = require('node-api-dotnet/net8.0');
    dotnet.System.Console.WriteLine('Hello from Node.js!');
}
main().catch(console.error);
