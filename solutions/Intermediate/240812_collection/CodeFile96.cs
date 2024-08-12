class Calculator
{
    public delegate int Del(int a, int b);
    public Del callback;
    public void Print(int a, int b)
    {
        Console.WriteLine(callback(a, b));
    }
}

class Program
{
    static int Add(int a, int b) { return a + b; }

    static void Main(string[] args)
    {
        Calculator Calc = new Calculator();
        Calc.callback = Add;
        Calc.Print(1, 2);       // 3    // Add(1, 2)
    }
}