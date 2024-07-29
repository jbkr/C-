// 중첩 if 피해라
class Program
{
    static void Main(string[] args)
    {
        int number = 7;
        if (number > 0 && number % 2 == 0)
        {
            Console.WriteLine("0보다 큰 짝수");
        }
        else if (number > 0 && number % 2 == 1)
        {
            Console.WriteLine("0보다 큰 홀수");
        }
        else
        {
            Console.WriteLine("0보다 작거나 같은 수");
        }

    }
}