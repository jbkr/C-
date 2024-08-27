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
        Thread thread = new Thread(() => Func("Good"));
        thread.Start();

        // Main
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello Main");
            Thread.Sleep(10);
        }

        thread.Join();

        Console.WriteLine("End");


    }
}