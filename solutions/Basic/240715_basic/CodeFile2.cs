class Program
{
    static void Main(string[] args)
    {
        // String.Format(  ) (서식 문자열)
        int n = 16;
        int m = 7;
        Console.WriteLine("화폐 16진수 표기 : {0:c}, {0:x}", n);      // currency

        String str = String.Format("문자열: {0:c}, {1:x}", n, m);
        Console.WriteLine(str);

        Console.WriteLine(DateTime.Now);    // 시간

        Console.WriteLine(String.Format("{0:dddd MMMM}", DateTime.Now));
    }
}