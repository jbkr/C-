// 함수를 주고 받기
// 콜백
// 연산방식을 전달

// expression-bodied member
class Program
{
    static bool IsPositive(int n) { return n > 0; }

    static void Main(string[] args)
    {
        int[] arr = { -10, 20, -30, 4, -5 };
        int result = Array.Find(arr, IsPositive);
        Console.WriteLine(result);

        int result1 = Array.Find(arr, n => n > 0);
        Console.WriteLine(result);

        var result2 = arr.Where(x => x > 0);
        foreach (int i in result2)
        {
            Console.WriteLine(i);
        }
    }
}