class Program
{
    //int Prn1(string s) { return s.Length; }
    delegate int Del1(string s);

    //int Prn2() { return 0; }
    delegate int Del2();

    //void Prn3(string s) { Console.WriteLine(s); }
    delegate void Del3(string s);

    //void Prn4() { }
    delegate void Del4();

    static void Main(string[] args)
    {
        Del1 del1 = s => s.Length;
        Console.WriteLine(del1("Hello"));
        Del2 del2 = () => 0;
        Console.WriteLine(del2());
        Del3 del3 = s => { Console.WriteLine(s); };
        del3("Hello");
        Del4 del4 = () => { Console.WriteLine("World"); };
        del4();

    }
}