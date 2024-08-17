class Program
{
    static int Print2(string s) { return s.Length; }

    static void Main(string[] args)
    {
        Func<string, int> func = s => s.Length;
        Console.WriteLine(func("Hello"));
    }
}