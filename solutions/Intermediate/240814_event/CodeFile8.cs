class Program
{
    static void Main(string[] args)
    {
        // 정수가 짝수인지 여부 ?
        //var IsEven = (int n) => { return n % 2 == 0; };
        var IsEven = (int n) => n % 2 == 0;
        Console.WriteLine(IsEven(2));

        // 두 실수의 합이 100이하 인지?
        var IsOver100 = (double d1, double d2) => d1 + d2 <= 100;
        Console.WriteLine(IsOver100(10.5, 90.0));

        // 배열을 받아서 10보다 작은 3의 배수 출력
        var output = (int[] array) =>
        {
            foreach (var item in array)
            {
                if (item < 10 && item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        };
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        output(array);
    }
}