// null 병합 연산자 ( ?? )
class Program
{
    static void Main(string[] args)
    {
        string str = null;
        Console.WriteLine($"{str ?? "0"}");

        string str1 = null;
        Console.WriteLine($"{str1 ?? "Default"}");

        str1 = "Specific";
        Console.WriteLine($"{str1 ?? "Default"}");
    }
}