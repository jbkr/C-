// partial
// 분할 클래스
// 하나의 클래스
// 클래스 사이즈가 클 때 -> 코드 관리 편하게

// MyClass1.cs
partial class MyClass
{
    public void Func1() { }
    //public void Func2() { }
}

// MyClass2.cs
partial class MyClass
{
    //public void Func1() { }
    public void Func2() { }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        myClass.Func1();
        myClass.Func2();
    }
}