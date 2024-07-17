// CTS(Common Type System) - 공용 형식 시스템
// .NET 형식 체계 준수

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("52".GetType());
        Console.WriteLine(int.Parse("33").GetType());
        Console.WriteLine(1234.GetType());

        int n = 100;
        Type type = n.GetType();
    }

}