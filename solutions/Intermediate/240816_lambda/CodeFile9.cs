class Program
{
    static void Main(string[] args)
    {

    }

    static void AfterTwoSecond(double a, double b, Action<double, double> act)
    {
        Thread.Sleep(2000);
        act(a, b);
    }
}