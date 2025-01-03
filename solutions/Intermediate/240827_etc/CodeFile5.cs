class Counter
{
    private int count;
    public int Count { get { return count; } }

    readonly object thisLock;   // 크리티컬 섹션 객체

    public Counter()
    {
        count = 0;
        thisLock = new object();
    }

    public void Increment()
    {
        int loopCount = 1000;
        while (loopCount-- > 0)
        {
            lock (thisLock)
            {
                count++;        // 동시 접근 - 보호
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Thread t1 = new Thread(counter.Increment);
        Thread t2 = new Thread(counter.Increment);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine(counter.Count);
    }
}