class Program
{
    static void Main(string[] args)
    {
        // C# 9
        Func<string, int> s2i = (string s) => int.Parse(s);
        int i = s2i("101");

        // C# 10
        var i2 = (string s) => int.Parse(s);
    }
}