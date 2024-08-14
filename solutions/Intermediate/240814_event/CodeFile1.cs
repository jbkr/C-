// 함수 전달

delegate int DelFunc(string s);

class Program
{
    static int Func(string s)
    {
        return s.Length;
    }

    // 델리게이트 객체 = Func;


    static void Main(string[] args)
    {
        DelFunc delFunc = Func;
        delFunc("abc");

        Console.WriteLine(Func("abc"));

        Callback(Func);
        Callback call = new Callback(Func);
    }

    static void Callback(DelFunc del)
    {
        Console.WriteLine(del("abc"));
    }
}

class Callback
{
    DelFunc delFunc;
    public Callback(DelFunc del) { delFunc = del; }
}