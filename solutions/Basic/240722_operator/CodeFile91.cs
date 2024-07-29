class Program
{
    static void Main(string[] args)
    {
        int? a = null;
        int b = a ?? 1;
        a ??= 100;      // a = a ?? 100;

        int[] rows = { 1, 2, 3, 4, 5 };
        int? cnt = rows?.Length;        // int? => value type을 null로

        int cnt2 = rows?.Length ?? 0;

        int? c = null;
        Console.WriteLine($"c ?? 10 : {c ?? 10}");
        c = 7;
        Console.WriteLine($"c ?? 10 : {c ?? 10}");


    }
}