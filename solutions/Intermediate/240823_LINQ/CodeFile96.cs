using System.Runtime.CompilerServices;

public static class Trace
{
    public static void WriteLine(string message,
        [CallerFilePath] string file = "")
    {
        Console.WriteLine(message, file);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}