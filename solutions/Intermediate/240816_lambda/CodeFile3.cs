class Program
{
    //delegate void Del(string s);

    //static void Print(string s) { Console.WriteLine(s); }

    static void Main(string[] args)
    {
        //Del del = Print;
        //Action<string> action = Print;
        //action("Hello");

        // Action 객체 = 람다; -> 가장 간단한 코드
        Action<string> action1 = s => Console.WriteLine(s);
        action1("World");
    }
}