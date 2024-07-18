class Program
{
    static void Main(string[] args)
    {
        var a = 20;
        var b = 3.1414213;
        var d = new int[] { 10, 20, 30 };

        //int a = null;     // error
        int? n = null;      // nullable     // 값 타입이지만 참조 타입처럼 null 처리
        Console.WriteLine(n != null);       // False
        Console.WriteLine(n.HasValue);      // False
        Console.WriteLine(n.Value);         // exception

        n = 100;
        Console.WriteLine(n != null);       // 
        Console.WriteLine(n.HasValue);      // 
        Console.WriteLine(n.Value);         // 

        int c = 10;
        System.Int32 d = 10;                // CTS

    }
}