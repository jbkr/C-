// 다중 상속
// 동시 상속 ( 여러 개의 인터페이스 상속 )

class Parent { }
class Parent2 { }
interface IParent { }       // 인터페이스화

//class Child: Parent, Parent2 { }        // 클래스 다중 상속 X
class Child : Parent, IDisposable, IComparable, IParent
{
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Child();
        IDisposable disposable = new Child();
        IComparable comparable = new Child();
    }
}