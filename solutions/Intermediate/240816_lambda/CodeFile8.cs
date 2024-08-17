class Program
{
    static void Main(string[] args)
    {
        Func<int> func1 = () => 10;     // int (void)
        Action act1 = () => Console.WriteLine("Hello");     // void (void)
    }
}