class Program
{
    //delegate void Del(string s);

    static void Print(string s) { Console.WriteLine(s); }

    static void Main(string[] args)
    {
        //Del del = Print;
        Action<string> action = Print;
        action("Hello");
    }
}