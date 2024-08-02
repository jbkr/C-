

class Program
{
    interface ILogger
    {
        void WriteLog(string log);
    }

    static void Log1(ILogger logger)            // 인터페이스 사용 // 미리 만들어 놓을 수 있다
    {

    }

    class ConsoleLogger : ILogger               // 인터페이스 구현 // 분리 가능
    {
        public void WriteLog(string log)        // 메서드 구현이 강제된다
        {
            // code
        }
    }

    class FileLogger
    {
        public void WriteFile(string log)
        {
            // code
        }

        public void WriteLog(string log)
        {

        }
    }

    class FileLogger1 : ILogger
    {
        public void WriteLog(string log)
        {

        }
    }

    static void Log(ConsoleLogger consoleLogger)
    {

    }

    static void Log(FileLogger fileLogger)
    {

    }

    static void Log(ILogger logger)
    {

    }

    static void Main(string[] args)
    {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        consoleLogger.WriteLog("dsljfldf");

        FileLogger fileLogger = new FileLogger();
        fileLogger.WriteFile("sljfl");                      // 함수 통일
    }
}