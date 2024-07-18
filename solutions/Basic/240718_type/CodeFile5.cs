using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        // 처리 프로세스
        // while, for, foreach
        for (int i = 0; i < 10000; i++)
        {
            for (int j = 0; j < 10000; j++)
            {
                int n = 0; n++;
            }
        }

        sw.Stop();

        Console.WriteLine("time : " + sw.ElapsedMilliseconds + "ms");

    }
}