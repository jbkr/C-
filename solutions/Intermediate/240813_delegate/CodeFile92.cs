class MyTimer
{
    public delegate void Tick(DateTime now);
    public event Tick Ticked;
    private int interval;

    public MyTimer(int interval)
    {
        this.interval = interval;
    }

    public void start()
    {
        DateTime before = DateTime.Now;
        while (true)
        {
            DateTime current = DateTime.Now;
            if (before.AddSeconds(interval) < current)
            {
                Ticked(current);
                before = current;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyTimer timer = new MyTimer(5);                 // 5
        timer.Ticked += new MyTimer.Tick(TimeElapsed);  // TimeElapsed
        timer.start();
    }

    static void TimeElapsed(DateTime current)
    {
        Console.WriteLine("Time Elapsed : {0}", current.ToLongTimeString());
    }
}