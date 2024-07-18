using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine((int)'가');        // unicode
        Console.WriteLine(sizeof(int));     // byte 수

        // Seoul, Busan, Inchon
        string[] cities = new string[3] { "Seoul", "Busan", "Inchon" };

        // 콘솔 입력 문자열 길이
        string s = Console.ReadLine();
        Console.WriteLine(s.Length);

        // 두 개 실수 입력, 평균(소수점 두 자리)
        double d1 = double.Parse(Console.ReadLine());
        double d2 = double.Parse(Console.ReadLine());
        double average = (d1 + d2) / 2;
        Console.WriteLine(average.ToString("0.00"));

        // 정수 1234567 세자릿수 단위
        int a = 1234567;
        Console.WriteLine("{ 0:#,0}", a);

        // 오늘의 날짜
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);

        // 현재 시간 "00:00:00"
        DateTime now = DateTime.Now;
        Console.WriteLine("{0} {1} {2}", now.Hour, now.Minute, now.Second);

        // 2000년 1월 1일부터 오늘까지 지난 일수
        DateTime dateTime1 = new DateTime(2000, 1, 1);
        TimeSpan t = DateTime.Now - dateTime1;
        Console.WriteLine(t.TotalDays);
    }
}