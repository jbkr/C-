class Program
{
    static void Main(string[] args)
    {
        // 1sec 후 문자열 출력

        PrintAfterOneSecond("Hello",
            (s) => Console.WriteLine(s)
            );
    }

    static void PrintAfterOneSecond(string s, Action<string> action)
    {
        Thread.Sleep(1000);
        action(s);
    }
}