
class Program
{
    static IEnumerable<int> GetNumber()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }

    static void Main(string[] args)
    {
        foreach (int i in GetNumber())
        {
            Console.WriteLine(i);
        }
    }
}