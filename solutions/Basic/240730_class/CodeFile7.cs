class GameInfo
{
    public static string Version = "Version 1.1";

    //private GameInfo() { }
    //static GameInfo(string version)       // 매개 변수 X
    static GameInfo()
    {
        Version = "Version 1.0";
    }
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
        Console.WriteLine(GameInfo.Version);      // 접근 시 정적 생성자 자동 호출
        //GameInfo gameInfo = new GameInfo();     // static 용도로만 사용하고자 하나 객체 생성이 될 수 있다 -> 방지 (private)
        GameInfo gameInfo = new GameInfo();       // 의미 없음 ( 위에서 생성자 이미 호출됨 )
    }
}