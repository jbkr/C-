class Mammal
{
    public void Nurse() { Console.WriteLine("Nurse()"); }
    public void Eat() { }
}

class Dog : Mammal
{
    public new void Eat() { }       // hiding   // new 는 새로운 메서드 생성
    public void Bark() { Console.WriteLine("Bark()"); }
}

class Cat : Mammal
{
    public void Meow() { Console.WriteLine("Meow()"); }
}

class Program
{
    static void Main(string[] args)
    {

    }
}