class Program
{
    static void Main(string[] args)
    {
        // 무명 형식    // 익명 객체 ( anonymous type )
        var a = new { Name = "홍길동", Age = 17 };     // no class name    // ** 읽기 전용 ** 프로퍼티
        Console.WriteLine(a.Name);    // property
        Console.WriteLine(a.Age);     // property
        //a.Age = 20;   // Error
    }
}