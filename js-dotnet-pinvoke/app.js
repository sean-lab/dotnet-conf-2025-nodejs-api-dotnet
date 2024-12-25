import dotnet from 'node-api-dotnet';

const PinvokeMacosModule = dotnet.require('../pinvoke-macos/bin/Debug/net8.0/pinvoke-macos.dll');

const systemInfo = PinvokeMacosModule.LibcWrapper.uname();

console.log(systemInfo.sysname);
console.log(systemInfo.nodename);
console.log(systemInfo.release);
console.log(systemInfo.version);
console.log(systemInfo.machine);
