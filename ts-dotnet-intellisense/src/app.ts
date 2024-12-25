import dotnet from 'node-api-dotnet/net8.0';
import { MyDotnetClass } from '../MyDotnetClass/bin/Debug/net8.0/MyDotnetClass';

const MyDotnetClassModule = dotnet.require('./MyDotnetClass/bin/Debug/net8.0/MyDotnetClass.dll') as { MyDotnetClass: typeof MyDotnetClass };

const myObject = new MyDotnetClassModule.MyDotnetClass();
console.log(myObject.myDotnetMethod(".NET Conf 2025 Seoul"));