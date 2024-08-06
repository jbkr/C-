class Program
{
    class SubjectScore
    {
        public string Subject { get; set; }
        public int[] Scores;
    }

    static void Main(string[] args)
    {
        var subject = new
        {
            Subject = "Math",
            Scores = new int[] { 90, 80, 80 }
        };
        Console.WriteLine(subject.Subject);
        foreach (var item in subject.Scores)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
    }
}