// ICloneable
// deep copy

class Alpha
{
    public string A;
    public string B;
}

class Program
{
    static void Main(string[] args)
    {
        Alpha obj1 = new Alpha() { A = "배고파서", B = "눈물" };
        Alpha obj2 = obj1;      // 참조 copy
        obj2.B = "ㅠㅠ";

        Console.WriteLine(obj1.A + " " + obj1.B);
        Console.WriteLine(obj2.A + " " + obj1.B);

        Alpha obj3 = new Alpha();
        obj3.A = obj1.A;
        obj3.B = obj1.B;

        Console.WriteLine(obj1.A + " " + obj1.B);
        Console.WriteLine(obj3.A + " " + obj3.B);

        //Alpha obj4 = obj1.Clone() as Alpha;     // Clone()  // ICloneable

    }
}