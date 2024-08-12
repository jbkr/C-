// 같은 형식

class Program
{
    static double StringToDouble(string s)
    {
        bool b = double.TryParse(s, out double d);
        return d;
    }
    static bool IsEven(int n) { return n % 2 == 0 ? true : false; }
    static void PrintHello() { Console.WriteLine("Hello"); }

    delegate double Del1(string s);
    delegate bool Del2(int n);
    delegate void Del3();

    static void Main(string[] args)
    {
        Del1 del1 = StringToDouble;
        Del2 del2 = IsEven;
        Del3 del3 = PrintHello;

        Console.WriteLine(del1("Hello"));
        Console.WriteLine(del2(3));
        del3();
    }
}