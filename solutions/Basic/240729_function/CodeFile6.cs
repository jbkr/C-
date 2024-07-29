using _240729_function;

class Cat       // 이름, 색, 야옹울음을 운다
{
    public string name;
    public string color;

    public void Meow()
    {
        Console.WriteLine("야옹");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.name = "Kitty";
        cat.color = "White";
        cat.Meow();

        Cat cat2 = new Cat() { name = "Kitty", color = "White" };       // 중괄호를 통한 초기화

        Class1 class1 = new Class1();
        
    }
}