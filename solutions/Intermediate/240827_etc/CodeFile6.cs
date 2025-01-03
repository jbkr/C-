// Tasks namespace
// Task, Task<TResult>, Parallel

class Program
{
    static void Func()
    {
        Console.WriteLine("Func method");
    }

    static void Main(string[] args)
    {
        // void
        Task task = Task.Run(Func);
        task.Wait();

        Task task1 = new Task(Func);
        task1.Start();
        task1.Wait();

        Task task2 = Task.Run(() => { Console.WriteLine("Func"); });    // Action
        task2.Wait();

        // Task<T>.Run
        Task<int> task3 = Task<int>.Run(() => { return 10; });
        task3.Wait();
        Console.WriteLine(task3.Result);
    }
}