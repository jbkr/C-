//Parallel.ForEach

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelExample
{
    class Program
    {
        static void Main()
        {
            var limit = 2_000_000;
            var numbers = Enumerable.Range(0, limit).ToList(); // sources

            var watch1 = Stopwatch.StartNew();
            var primeNumbers1 = GetPrimeList(numbers);                  // sequential
            watch1.Stop();

            var watch2 = Stopwatch.StartNew();
            var primeNumbers2 = GetPrimeListWithParallel(numbers);      // parallel
            watch2.Stop();

            Console.WriteLine($"Classical foreach loop | Total prime numbers : {primeNumbers1.Count} | Time Taken : {watch1.ElapsedMilliseconds} ms.");
            Console.WriteLine($"Parallel.ForEach loop  | Total prime numbers : {primeNumbers2.Count} | Time Taken : {watch2.ElapsedMilliseconds} ms.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        /// GetPrimeList returns Prime numbers by using sequential ForEach
        private static IList<int> GetPrimeList(IList<int> numbers) => numbers.Where(IsPrime).ToList();

        /// GetPrimeListWithParallel returns Prime numbers by using Parallel.ForEach
        private static IList<int> GetPrimeListWithParallel(IList<int> numbers)
        {
            var primeNumbers = new ConcurrentBag<int>();

            Parallel.ForEach(numbers, number =>
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
            });

            return primeNumbers.ToList();
        }

        /// IsPrime returns true if number is Prime, else false.
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0) return false;
            }
            return true;
        }
    }
}

//https://docs.microsoft.com/ko-kr/dotnet/standard/parallel-programming/data-parallelism-task-parallel-library