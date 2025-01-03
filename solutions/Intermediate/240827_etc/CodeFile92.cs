class Program
{
    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0) return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        //Parallel.ForEach(() => { });
        //Parallel.Invoke();    // 여러 개의 Task 병렬 실행
    }
}