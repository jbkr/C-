class MyClass
{
    public static void Method1()
    {
        Console.WriteLine("static");
    }
    public void Method2()
    {
        Console.WriteLine("none static");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass.Method1();
        MyClass myClass = new MyClass();
        myClass.Method2();
        //myClass.Method1();          // error
    }
}