using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // DateTime -> value type ( struct )
        string name = "Mark";

        var date = DateTime.Now;     // var => C++ auto
        Console.WriteLine(date);

        Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        double d = 1.12345;
        Console.WriteLine(d.ToString("0.000"));

        double won = 1234567;
        Console.WriteLine(String.Format("{0:#,0}", won));

        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
        //while (true)
        //{
        //    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        //}
        // .Net에 구현된 클래스
    }
}