class Test
{
    public int value = 10;
}

class Program
{
    static void Func(int a, Test t)      // value type, reference type
    {
        t.value = a;
    }

    static void Divide(int a, int b, out int c, out int d)
    {
        c = a / b;
        d = a % b;
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Func(1, test);

        bool b = int.TryParse("123a", out int rt);       // 123
        if (b)
        {
            Console.WriteLine(rt);
        }
        else
        {
            Console.WriteLine(rt);
        }

        Divide(10, 3, out int c, out int d); // 몫과 나머지
        Console.WriteLine(c + " " + d);
    }
}