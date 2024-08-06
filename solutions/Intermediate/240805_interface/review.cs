class Alpha : ICloneable
{
    public string A;
    public string B;

    public object Clone()
    {
        return new Alpha() { A = this.A, B = this.B };
    }
}

class Program
{
    static void Main(string[] args)
    {
        Alpha obj1 = new Alpha() { A = "Hello", B = "World" };
        Alpha obj2 = obj1;
        Alpha? obj3 = obj1.Clone() as Alpha;
        Console.WriteLine(obj1.A + " " + obj1.B);

        obj2.B = "Man";
        Console.WriteLine(obj1.A + " " + obj1.B);

        Console.WriteLine(obj3.A + " " + obj3.B);

    }
}