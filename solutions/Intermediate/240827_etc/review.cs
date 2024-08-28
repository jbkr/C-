
class Program
{
    static void Doit()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Doit");
    }

    static async void DoitAsync()
    {
        await Task.Run(Doit);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("start");
        Doit();
        DoitAsync();
        Console.WriteLine("Done");
        Console.ReadLine();
    }
}