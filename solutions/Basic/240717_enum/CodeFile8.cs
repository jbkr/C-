class Program
{
    static void Main(string[] args)
    {
        // _(밑줄)을 사용하여 자리수를 분리
        //int 백만 = 1000000;
        int 백만 = 1_000_000;
        int hexa = 0x_FF_00;
        int bin = 0b0000_0111_0011;

        // int 자료형의 바이트 수를 출력하라
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(System.Int32));

        int level = 100;
        Console.WriteLine(int.MaxValue);
        //int exp = 10000000000000000;      // overflow
        //long exp=

        // 특정 진법 문자열로 바꾸기
        int a = 100;
        Console.WriteLine("2진수 : " + Convert.ToString(a, 2));
        Console.WriteLine("8진수 : " + Convert.ToString(a, 8));
        Console.WriteLine("16진수 : " + Convert.ToString(a, 16));

        // 특정 진법 문자열을 숫자로 바꾸기
        int b1 = Convert.ToInt32("11110000", 2);
        Console.WriteLine(b1);  // 240

        // overflow
        uint ua = uint.MaxValue;
        Console.WriteLine(ua);
        ua = ua + 1;
        Console.WriteLine(ua);

        // underflow
        uint ub = uint.MinValue;
        Console.WriteLine(ub);
        ub = ub - 1;
        Console.WriteLine(ub);
        // 순환

        // 접미사
        uint ui = 10U;
        long l = 100L;
        double d = 3;
        float f = 3_000.5f;
        decimal money = 3_000.5m;
    }

}