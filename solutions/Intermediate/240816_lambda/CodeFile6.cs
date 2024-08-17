class Program
{
    static void Main(string[] args)
    {
        // 정수가 짝수
        Func<int, bool> func = n => n % 2 == 0;
        Console.WriteLine(func(5));

        // 두 실수의 합이 100이하
        Func<double, double, bool> func1 = (a, b) => a + b <= 100;
        Console.WriteLine(func1(3.3, 9.2));

        // 배열 10보다 작은 3의 배수 출력
        Action<int[]> action = arr =>
        {
            foreach (var item in arr)
            {
                if (item < 10 && item % 3 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        };
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        action(arr);
    }
}