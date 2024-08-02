// 확장메서드

class Program
{
    static void Main(string[] args)
    {
        float f = 0.12345f;
        Console.WriteLine(f.PointTwo());        // "0.12"
    }
}

public static class Ex
{
    public static string PointTwo(this float f)
    {
        return f.ToString("0.00");
    }
}