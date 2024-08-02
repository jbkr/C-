interface ILogger
{
    void WriteLog(string message);
}

interface IConsoleLogger : ILogger          // interface 상속
{
    void WriteLog(string format, params object[] args);
}

class Program
{
    static void Main(string[] args)
    {

    }
}