class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(1 / 2 + 1 / 2);

        int number = 10;
        Console.WriteLine(++number);
        Console.WriteLine(number++);
        Console.WriteLine(number);

        int a = 10;
        Console.WriteLine(++a);
        Console.WriteLine(a++);
        Console.WriteLine(--a);
        Console.WriteLine(a--);

        int b = 0;
        Console.WriteLine(++b + b++);       // 안 좋은 코드
        Console.WriteLine(b);

        Console.WriteLine('0' + '1');

        int level = 120;
        string s = level.ToString();
        string s = level + "";

        int hp_cur = 30;
        int hp_max = 100;
        float per = (float)hp_cur / hp_max;
        Console.WriteLine(per.ToString("0.00"));

        // C# 에서의 문자열 비교
        Console.WriteLine("{0}", "abc" == "abc");
        Console.WriteLine("{0}", "abc".Equals("abc"));
        // 문자열 자체 또는 문자열 레퍼런스

        Console.WriteLine($"{1 == 0 && 4 < 5 || 4 < 5}");   // || 기준으로 판단

    }
}