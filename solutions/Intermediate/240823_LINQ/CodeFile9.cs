class Program
{
    static void Main(string[] args)
    {
        // Range

        var numbers = from n in Enumerable.Range(100, 50)
                      select (Number: n, OddEven: n % 2 == 1 ? "odd" : "even");

        var numbers2 = Enumerable.Repeat(7, 10);
    }
}