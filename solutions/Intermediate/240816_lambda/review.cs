class Program
{
    static void Main(string[] args)
    {
        Predicate<int> predicate = n => n > 5;
        Console.WriteLine(predicate(20));

        Predicate<string> predicate1 = s => s.StartsWith("A");
        Console.WriteLine(predicate1("Apple"));
    }

}