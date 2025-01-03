class Program
{
    static int CalcSize(string data)
    {
        string s = data == null ? "" : data.ToString();
        Thread.Sleep(1000);
        return s.Length;
    }

    static void Main(string[] args)
    {
        // Task<T>.Run
        // Task.Factory.StartNew<T>
        Task<int> task1 = Task<int>.Run(() => CalcSize("Hello"));
        task1.Wait();
        Console.WriteLine(task1.Result);
    }
}