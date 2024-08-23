class Program
{
    static void Main(string[] args)
    {
        // 분할 연산자 // Take, Skip, TakeWhile, SkipWhile

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var first3Numbers = numbers.Take(3);  // { 5, 4, 1 }

        var allButFirst4Numbers = numbers.Skip(4);  // { 9, 8, 6, 7, 2, 0 }

        var o3 = numbers.TakeWhile(n => n < 6);

        var o4 = numbers.SkipWhile(n => n < 6);
    }
}