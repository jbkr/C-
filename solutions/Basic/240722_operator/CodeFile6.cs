class Program
{
    static void Main(string[] args)
    {
        int b = 0;
        if (1 > 0 || ++b > 1)
            Console.WriteLine(b);

        Console.WriteLine("good " + "day");
        Console.WriteLine("Level: " + 100);
        Console.WriteLine("0" + "1");
        Console.WriteLine('0' + 1);     // unicode

        int? c = null;
        Console.WriteLine(c ?? 10);
    }
}