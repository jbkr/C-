class Cat
{
    string name="";
    string color="";

    public Cat()
    {
        this.name = "Hello";
    }

    public Cat(string color): this()
    {
        
        this.color = color;
    }

    ~Cat() { }

    public void Meow()
    {
        Console.WriteLine("야옹");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Gold");
        cat.Meow();
    }
}
