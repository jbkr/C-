class Program
{
    static void Main(string[] args)
    {
        //Func<int, bool> p =
        Predicate<int> p = (int n) => { return n > 5; };
        bool b1 = p(6);   // True
        bool b2 = p(4);   // False

        Predicate<string> p2 = s => s.StartsWith("A");
        bool b3 = p2("Apple");
        Console.WriteLine(b3);  // True
    }
}