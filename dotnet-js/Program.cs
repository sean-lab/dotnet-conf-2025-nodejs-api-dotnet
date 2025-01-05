using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.JavaScript.NodeApi;
using Microsoft.JavaScript.NodeApi.Runtime;

class Program
{
    static async Task Main(string[] args)
    {
        string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
        NodejsPlatform nodejsPlatform = new(Path.Combine(baseDir, "libnode.115.dylib"));
        var nodejs = nodejsPlatform.CreateEnvironment(baseDir);

        await nodejs.RunAsync(async () =>
        {
            var script = "x = 10;";
            JSValue.RunScript(script);

            var x = (int)JSValue.Global["x"];
            Console.WriteLine($"Access x in JS from .NET: {x}");

            x = x * x;
            JSValue.Global.SetProperty("x", x);
            JSValue.RunScript("console.log(`Access x in JS from JS: ${x}`);");

            await Task.CompletedTask;
        });

        nodejs.Dispose();
    }
}