class Program
{
    static void Main(string[] args)
    {
        var scoreRecords = new[] {
            new { Name = "Alice", Score = 50 },
            new { Name = "Bob", Score = 40 },
            new { Name = "Cathy", Score = 45 }
        };
        var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);
    }
}