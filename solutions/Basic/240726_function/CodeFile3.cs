class Program
{
    static int Sum(params int[] args)   // params 가변길이 매개 변수
    {
        int sum = 0;
        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int total = 0;
        total = Sum(1, 2);
        total = Sum(1, 2, 3);
        total = Sum(1, 2, 3, 4);
        // 하나의 함수로 해결
    }
}