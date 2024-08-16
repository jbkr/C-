class Program
{
    static void Main(string[] args)
    {
        // Hello 출력
        Action<string> action = s => Console.WriteLine(s);
        action("Hello");

        Action act = () => { Console.WriteLine("Hello"); };     // void (void)
        act();

        // int x -> x * x
        Func<int, int> func = x => x * x;

        // int x -> print ( x * x )
        Action<int> action1 = x => { Console.WriteLine(x * x); };

        // double x, y -> x / y 출력
        //Action<double, double> action2 = (double x, double y) => { Console.WriteLine(x / y); };
        Action<double, double> action2 = (x, y) => { Console.WriteLine(x / y); };

        // 문자열 역순 출력
        Action<string> action3 = (s) =>
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string ns = new string(arr);
            Console.WriteLine(ns);
        };
    }
}