import dotnet from 'node-api-dotnet';

const PinvokeMacosModule = dotnet.require('../pinvoke-macos/bin/Debug/net8.0/pinvoke-macos.dll');

const systemInfo = PinvokeMacosModule.LibcWrapper.uname();

console.log(`System name: ${systemInfo.sysname}`);
console.log(`Node name: ${systemInfo.nodename}`);
console.log(`Release: ${systemInfo.release}`);
console.log(`Version: ${systemInfo.version}`);
console.log(`Machine: ${systemInfo.machine}`);
