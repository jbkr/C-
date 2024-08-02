abstract class Log
{
    public abstract void Print(string s);
    public int number = 1;          // 멤버 필드를 가질 수 있다 ( 추상 클래스 )
    public void Method() { Console.WriteLine(); }
}

interface ILog
{
    void Print(string s);
    //public int number = 1;        // 멤버 필드를 가질 수 없다 ( 인터페이스 )
}

class MyLog1 : ILog
{
    public void Print(string s)         // 자동 override
    {
        Console.WriteLine(s);
    }
}

class MyLog : Log
{
    public override void Print(string s)
    {
        Console.WriteLine(s);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Log log = new MyLog();
        log.Print("my log message");

        ILog log2 = new MyLog1();
        log2.Print("Hello");
    }
}