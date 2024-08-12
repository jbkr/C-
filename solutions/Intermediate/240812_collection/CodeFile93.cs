class Program
{
    delegate void MyDel1(string s);
    delegate bool MyDel2(int n);
    delegate int MyDel3(int n1, int n2);

    static void Func1(string s) { Console.WriteLine(s); }
    static bool Func2(int n) { return n > 0 ? true : false; }
    static int Func3(int n1, int n2) { return n1 * n2; }

    static void Main(string[] args)
    {
        MyDel1 myDel1 = Func1;
        MyDel2 myDel2 = Func2;
        MyDel3 myDel3 = Func3;

        myDel1("Hello");
        Console.WriteLine(myDel2(5));
        Console.WriteLine(myDel3(3, 6));
    }
}