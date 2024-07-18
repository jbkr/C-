using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // 두 개 실수 입력, 평균(소수점 두 자리)
        bool b1 = double.TryParse(Console.ReadLine(), out double d1);
        bool b2 = double.TryParse(Console.ReadLine(), out double d2);
        double average = (d1 + d2) / 2;
        Console.WriteLine(average.ToString("0.00"));

        // 정수 1234567 세자릿수 단위
        int a = 1234567;
        Console.WriteLine(string.Format("{0:#,0}", a));

        // 오늘의 날짜
        Console.WriteLine(DateTime.Now);

        // 현재 시간 "00:00:00"
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("hh:mm:ss"));
        // 2000년 1월 1일부터 오늘까지 지난 일수
        DateTime dateTime1 = new DateTime(2000, 1, 1);
        TimeSpan t = DateTime.Now - dateTime1;
        Console.WriteLine(t.TotalDays);
    }
}