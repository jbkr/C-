//Parallel.For

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelLoop
{
    class MainApp
    {
        static int MaxNumber = 100000;
        static void SomeMethod(long number)
        {
            for (int i = 0; i < number; i++) { }
            if (number == MaxNumber - 1)
                Console.WriteLine("Complete");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("start");

            // 1. 순차적 실행 // 동일쓰레드가 0~999 출력
            for (int i = 0; i < MaxNumber; i++)
            {
                SomeMethod(i);
            }

            // 2. 병렬 처리  // 다중쓰레드가 병렬로 출력  
            Parallel.For(0, MaxNumber, (i) => {
                SomeMethod(i);
            });
        }
    }
}

/*
// Parallel.For ---------------------------------------------------------

 class MainApp
    {
        static bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0 && number != 2) return false;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            //long from = Convert.ToInt64(args[0]);
            //long to = Convert.ToInt64(args[1]);

            long from = 1;
            long to = 100;

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            ConcurrentBag<long> total = new ConcurrentBag<long>();  //List<T> 

            Parallel.For(from, to, (long i) =>
            {
                if (IsPrime(i))
                    total.Add(i);
            });

            DateTime endTime = DateTime.Now;
            TimeSpan ellapsed = endTime - startTime;

            Console.WriteLine("Prime number count between {0} and {1} : {2}",
                from, to, total.Count);
            Console.WriteLine("Ellapsed time : {0}", ellapsed);
        }

    }
 
*/