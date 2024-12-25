using Microsoft.JavaScript.NodeApi;

[JSExport]
public class MyDotnetClass
{
    public string MyDotnetMethod(string input)
    {
        return $"Hello from .NET! You said: {input}";
    }
}