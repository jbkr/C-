// 비트 연산
class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);

        Console.WriteLine(~0);
        Console.WriteLine(~1);

        int c = 0x12A1;
        int d = 0x00FF;
        Console.WriteLine("0x{0:X4}", c & d);       // 바이트 추려내기
        Console.WriteLine("0x{0:X4}", c);
        Console.WriteLine("0x{0:X4}", (c & 0xFF00) >> 8);
        Console.WriteLine("0x{0:X4}", (c & 0x00FF) >> 0);

        int e = 1;
        Console.WriteLine("e        :{0:D5} (0x{0:X8})", e);
    }
}