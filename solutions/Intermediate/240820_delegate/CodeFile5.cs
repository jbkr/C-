class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("abc");
        list.Add("edf");
        list.Add("123");

        string? s = list.Find(s => s.Equals("abc"));
        Console.WriteLine(s);
    }
}