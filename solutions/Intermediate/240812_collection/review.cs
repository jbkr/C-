class Program
{
    static int Plus(int a, int b) { return a + b; }

    delegate int Del(int a, int b);

    static void Main(string[] args)
    {
        Del del = Plus;
        Console.WriteLine(del(1, 2));
        Func(del);
    }

    static void Func(Del del)
    {
        Console.WriteLine(del(2, 5));
    }
}