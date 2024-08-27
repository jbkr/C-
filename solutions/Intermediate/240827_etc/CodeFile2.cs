class Program
{
    static void Func(object obj)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello Thread " + obj);
            Thread.Sleep(10);
        }
    }

    static void Main(string[] args)
    {
        // Thread
        Thread t1 = new Thread(() => Func("param"));
        t1.Start();

        // Main
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello Main");
            Thread.Sleep(10);
        }

        t1.Join();
        Console.WriteLine("End");
    }
}