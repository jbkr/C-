class Program
{
    static void Main(string[] args)
    {
        string s2 = 123.ToString();
        string s3 = "" + 123;

        string g = "1.2345";
        char c2 = g[0];

        char[] ca = "Hello".ToCharArray();
        for (int i = 0; i < ca.Length; i++)
        {
            Console.WriteLine(ca[i]);
        }

        string str = new string(ca);
        Console.WriteLine(str);

        // 두 개의 숫자를 입력 받아 사칙연산
        // 소숫점 두 자리
        string t1 = Console.ReadLine();
        string t2 = Console.ReadLine();
        double d1 = double.Parse(t1);
        double d2 = double.Parse(t2);
        Console.WriteLine(d1 + d2);
        Console.WriteLine(d1 - d2);
        Console.WriteLine(d1 * d2);
        Console.WriteLine((d1 / d2).ToString("0.00"));
        string str1 = string.Format("{0:0.00}", d1 / d2);
        Console.WriteLine(str1);
    }
}