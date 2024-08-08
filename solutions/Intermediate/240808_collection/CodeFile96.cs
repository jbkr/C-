class Program
{
    static void Main(string[] args)
    {
        var A = new[] { 1, 2, 3 };
        var L = new List<int>(A) { [2] = 9 };
        foreach (var x in L)
        {
            Console.WriteLine(x);
        }
    }
}