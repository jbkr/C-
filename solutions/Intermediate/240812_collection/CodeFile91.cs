class Program
{
    static int Plus(int a, int b)
    {
        return a + b;
    }

    delegate int MyDel(int a, int b);

    static void Main(string[] args)
    {
        //MyDel myDel = new MyDel(Plus);
        MyDel myDel = Plus;
        Console.WriteLine(myDel(1, 2));

        Func(Plus);     // Callback
    }

    static void Func(MyDel plus)
    {
        Console.WriteLine(plus(2, 3));
    }
}