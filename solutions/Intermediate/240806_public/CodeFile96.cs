class MyClass
{
    public class SubClass { }

    private string message = "";

    private string desc = "MyClass 입니다.";
    public string Desc
    {
        get { return desc; }
    }

    public void Print()
    {
        Console.WriteLine(message);
    }

    public SubClass GetSubClass()
    {
        return new SubClass();
    }
}

class MyClass2
{
    public class SubClass { }

    private string message = "";

    //private string desc = "MyClass 입니다.";
    //public string Desc
    //{
    //    get => desc;
    //}
    public string Desc => "MyClass 입니다.";

    public void Print() => Console.WriteLine(message);

    public SubClass GetSubClass() => new SubClass();
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        myClass.Print();

        MyClass2 myClass2 = new MyClass2();
        myClass2.Print();
    }
}