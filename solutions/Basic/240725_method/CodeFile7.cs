class Program
{
    static void Swap1(int a, int b)
    {
        int temp = b;
        b = a;
        a = temp;
    }

    static void Swap2(ref int a, ref int b)
    {
        int temp = b;
        b = a;
        a = temp;
    }
    static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        Swap1(x, y);
        Console.WriteLine(x + " " + y);

        Swap2(ref x, ref y);
        Console.WriteLine(x + " " + y);


    }

}