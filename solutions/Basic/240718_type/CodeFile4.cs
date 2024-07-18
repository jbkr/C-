class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime();     // 값 타입 // 구조체 멤버 => 스택에 올라간다
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(DateTime.Now);

        // 시간 간격    // TimeSpan
        TimeSpan ts = DateTime.Now - new DateTime(2024, 1, 1);
        Console.WriteLine((int)ts.TotalDays);

        TimeSpan ts2 = new DateTime(2024, 12, 25) - DateTime.Now;
        Console.WriteLine((int)ts2.TotalDays);

        // 클래스 이름 기억

    }
}