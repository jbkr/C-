// 정수 연산 결과는 정수
// 10/4=2

// 문자 -> 2 바이트 유니코드
// sizeof -> 바이트 수
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(10 / 4);
        Console.WriteLine(-4 % 3);
        Console.WriteLine(-4 % -3);
    }
}