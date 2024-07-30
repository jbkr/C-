// method overloading
// 매개변수가 다를 때
// 이름에 대한 고민을 덜어준다
//int Plus(int a,int b)
//{
//    return a + b;
//}

//double Plus(double a,double b)
//{
//    return a + b;
//}

// 다형성

class Program
{
    static void PrintAdd(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void PrintAdd(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    static void Main(string[] args)
    {
        PrintAdd(1, 2);     // 3    // int
        PrintAdd(1.2, 2.1); // 3.3  // double
    }
}