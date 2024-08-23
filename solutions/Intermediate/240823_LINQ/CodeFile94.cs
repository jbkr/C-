// 애트리뷰트
// vs 주석
// []

class MyClass
{
    [Obsolete("use NewMethod")]     // 생성자
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