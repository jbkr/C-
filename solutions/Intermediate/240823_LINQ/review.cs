class MyClass
{
    [Obsolete("This method is going to be deprecated. Use NewMethod")]
    public void OldMethod()
    {
        Console.WriteLine("I'm old");
    }

    public void NewMethod()
    {
        Console.WriteLine("I'm new");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        myClass.OldMethod();
    }
}