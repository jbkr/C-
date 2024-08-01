class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(2.Add(1));    // 3
        Console.WriteLine(2.Add(2));    // 4
    }
}

public static class MyEx
{
    public static int Add(this int n, int number)
    {
        return n + number;
    }
}