class Button
{
    // 함수 ( void f() )
    public delegate void Del();
    public Del func;
    public void OnClick() { func(); }
    // 클릭 - 함수를 실행
}

class Program
{
    static void Func() { Console.WriteLine("씬 전환"); }

    static void Main(string[] args)
    {
        Button btn = new Button();
        btn.func = Func;
        btn.OnClick();
    }
}