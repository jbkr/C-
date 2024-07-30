class GameInfo
{
    public static string Version = "Version 1.0";
}

class UI
{
    public void Show()
    {
        //Console.WriteLine("Version 1.0");       // 중복
        Console.WriteLine(GameInfo.Version);      // 객체 생성 없이 접근
    }
}

class Shop
{
    public void Show()
    {
        //Console.WriteLine("Version 1.0");       // 중복 -> 여러 군데 수정
        Console.WriteLine(GameInfo.Version);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}