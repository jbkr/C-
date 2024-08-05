class Dummy : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("리소스 해제");    // close()
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Dummy dummy = new Dummy();
        //dummy.Dispose();

        using (Dummy dummy = new Dummy())   // www, DB, File
        {
            // 사용
        }   // Dispose() 자동 호출
    }
}