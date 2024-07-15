
class Program
{
    static void Main(string[] args)
    {
        //char ch = '가';  // 2bytes
        string str = Console.ReadLine();
        char ch = str[0];

        if ((int)ch < '가' || (int)ch > '힣')
        {
            Console.WriteLine("한글 아님");
        }

        Console.WriteLine(ch);
        Console.WriteLine((int)ch);
    }
}

// 입출력
// 자료형