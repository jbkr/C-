class Absolute
{
    public int value = 0;
}

class Program
{
    static void Sum1()
    {
        bool b = int.TryParse(Console.ReadLine(), out int num);
        int sum = 0;
        for (int i = 0; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    static int Abs1(int num)
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }

    static void Abs2(Absolute a)
    {
        if (a.value < 0)
        {
            a.value = -a.value;
        }
    }

    static bool Sum2(int a, int b, out int sum)
    {
        sum = a + b;
        if (sum < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //static int Sum3()
    //{
    //    while (true)
    //    {
    //        bool b1 = int.TryParse(Console.ReadLine(), out int num1);
    //        bool b2 = int.TryParse(Console.ReadLine(), out int num2);

    //        if (b1 == false || b2 == false)
    //        {
    //            Console.WriteLine("다시 입력하세요");
    //        }
    //    }
    //    bool b1=int.TryParse(Console.ReadLine(), out int num1);
    //    bool b2=int.TryParse(Console.ReadLine(), out int num2);
        
    //    if(b1==false||b2==false)
    //    {
    //        Console.WriteLine("다시 입력하세요");
    //    }
    //    return num1 + num2;
    //}

    static void Main(string[] args)
    {
        Sum1();
        int n = Abs1(-20);
        Console.WriteLine(n);

        Absolute a = new Absolute();
        a.value = -30;
        Abs2(a);
        Console.WriteLine(a.value);

        bool b = Sum2(3, 5, out int sum);
        Console.WriteLine(sum);
        Console.WriteLine(b);
    }

}