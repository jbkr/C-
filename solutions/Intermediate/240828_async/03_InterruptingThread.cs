class Counter
{
    private int count;              // 보호하려는 자원
    public int Count { get { return count; } }

    public Counter() { count = 0;  }

    public void Increment()
    {
        int loopCount = 1000;
        while (loopCount-- > 0)
        {
            count++;                //count
        }
    }
}
class MainApp
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        counter.Increment();
        Console.WriteLine(counter.Count);  //???
    }
}