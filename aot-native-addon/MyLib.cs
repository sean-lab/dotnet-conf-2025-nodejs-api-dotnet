using Microsoft.JavaScript.NodeApi;

[JSExport]
public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}