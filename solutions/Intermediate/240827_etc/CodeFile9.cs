// Task    - 결과 X
// Task<T> - 결과 O

class Program
{
    // 1부터 100000 더하기

    static long Sum(int fr, int to)
    {
        long total = 0;
        for (int i = fr; i <= to; i++)
        {
            total += i;
        }
        return total;
    }

    // 스레드 4개

    static void Main(string[] args)
    {
        long singleSum = Sum(1, 100000);
        Console.WriteLine(singleSum);

        Task<long>[] tasks = new Task<long>[4];
        for (int i = 0; i < 4; i++)
        {
            tasks[i] = Task<long>.Run(() => { return 1L; });
            tasks[i].Wait();
        }

        Task<long> task1 = Task<long>.Run(() => Sum(1, 25000));
        Task<long> task2 = Task<long>.Run(() => Sum(25001, 50000));
        Task<long> task3 = Task<long>.Run(() => Sum(50001, 75000));
        Task<long> task4 = Task<long>.Run(() => Sum(75001, 100000));
        task1.Wait();
        task2.Wait();
        task3.Wait();
        task4.Wait();
        long sum1 = task1.Result;
        long sum2 = task2.Result;
        long sum3 = task3.Result;
        long sum4 = task4.Result;
        long sum = sum1 + sum2 + sum3 + sum4;
        Console.WriteLine(sum);
    }
}