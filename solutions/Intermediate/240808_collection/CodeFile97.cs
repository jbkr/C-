class Program
{
    static void Main(string[] args)
    {
        var scores = new Dictionary<string, int>()
        {
            {"Kim",100 },
            {"Lee",90 }
        };

        foreach (var score in scores)
        {
            Console.WriteLine(score.Key + " " + score.Value);
        }

        if (scores.ContainsKey("Kim")) { }
        if (scores.ContainsValue(100)) { }
    }
}