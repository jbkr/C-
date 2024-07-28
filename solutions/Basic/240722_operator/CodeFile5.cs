// 연습 문제
class Program
{
    static void Main(string[] args)
    {
        int Level = 0;
        Level = Level + 1;
        Level += 1;
        Level++;

        int a = 5;
        Console.WriteLine(a > 3 && a <= 9);

        int n = 5;
        Console.WriteLine(n % 2 == 0);

        // ++   *   +   &&  =

        Console.WriteLine(sizeof(char));

        int b = 10;
        b %= 3;
        b++;
        b >>= 1;
        Console.WriteLine(b);

        // 연산자 완벽하게 사용
        int c = 1;
        Console.WriteLine(a++);
        Console.WriteLine(++a);
        Console.WriteLine(3 / 2);
        Console.WriteLine(9 ^ 3);   // XOR  // 1001 0011 => 1010 => 10
        Console.WriteLine(1 + 2 * 3 / 2 << 1);
        //Console.WriteLine((1 + ((2 * 3) / 2)) << 1);
        
    }
}