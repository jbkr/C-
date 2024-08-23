// 집계 작업 Aggregators
// Count, Sum, Min, Max, Average, Aggregate

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        int oddNumbers = numbers.Count(n => n % 2 == 1);

        int[] factorsOf300 = { 2, 2, 3, 5, 5 };
        int num = factorsOf300.Distinct().Count();
    }
}