// optional parameter
// 기본값 설정
// 맨 뒤부터 기본값 설정

class Program
{
    static void MyMethod(int a = 0)
    {
        Console.WriteLine("{0}", a);
    }

    static void Print(string name = "", string phone = "")
    {
        Console.WriteLine(name + " " + phone);
    }

    static void Main(string[] args)
    {
        Print("Kim");
    }
}