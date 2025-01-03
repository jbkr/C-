class Program
{
    static void Run() { }

    static void Calc(object obj) { }

    static int Sum(int a, int b, int c) { return 0; }  // 매개변수 여러 개 - void ()

    static void Main(string[] args)
    {
        Thread thread = new Thread(() => Calc(10.00));
    }
}