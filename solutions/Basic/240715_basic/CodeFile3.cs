class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0,10}DEF", "ABC");
        Console.WriteLine("{0,-10}DEF", "ABC");
        Console.WriteLine("{0:X}", 255);
        Console.WriteLine("{0:N}", 123456789);
    }
}