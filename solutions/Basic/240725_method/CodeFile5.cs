class A
{
    public void Func1() { }
    public static void Func2() { }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A(); a.Func1();           // Base
        A.Func2();                          // static

        Console.WriteLine();                // static class ( Console ) // static member ( WriteLine )
    }

}