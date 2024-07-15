class Program
{
    static void Main(string[] args)
    {
        bool b = true;
        Console.WriteLine(b);
        Console.WriteLine(false);
        Console.WriteLine(1 < 2);

        Console.WriteLine(sizeof(char));

        object a1 = 10;
        object a2 = 'A';
        object a3 = "Hello";
        object a4 = true;
        // 최상위 클래스

        Console.WriteLine(a1.GetType());

    }
}
