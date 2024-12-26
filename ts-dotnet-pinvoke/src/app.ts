import dotnet from 'node-api-dotnet/net8.0';
import { LibcWrapper, SystemInfo } from '../../pinvoke-macos/bin/Debug/net8.0/pinvoke-macos';

const PinvokeModule = dotnet.require('../pinvoke-macos/bin/Debug/net8.0/pinvoke-macos.dll') as {
    LibcWrapper: typeof LibcWrapper;
};

const systemInfo: SystemInfo = PinvokeModule.LibcWrapper.uname();

console.log(`System name: ${systemInfo.sysname}`);
console.log(`Node name: ${systemInfo.nodename}`);
console.log(`Release: ${systemInfo.release}`);
console.log(`Version: ${systemInfo.version}`);
console.log(`Machine: ${systemInfo.machine}`);
