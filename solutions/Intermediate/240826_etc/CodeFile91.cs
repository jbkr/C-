class Program
{
    static void Func()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello Thread");
            Thread.Sleep(10);
        }
    }

    static void Main(string[] args)
    {
        // Thread
        Thread t1 = new Thread(new ThreadStart(Func));
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