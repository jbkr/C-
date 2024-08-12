// calculator

class Program
{
    static int Add(int a, int b) { return a + b; }
    static int Sub(int a, int b) { return a - b; }
    static int Mul(int a, int b) { return a * b; }

    delegate int MyDel(int a, int b);       // ** type ( like class )

    static void Calculator(int a, int b, MyDel del)
    {
        Console.WriteLine(del(a, b));
    }

    static void Main(string[] args)
    {
        Calculator(10, 3, Add);
        Calculator(10, 3, Sub);
        Calculator(10, 3, Mul);
    }
}