class Mammal
{
    public void Nurse() { Console.WriteLine("Nurse()"); }
    public void Eat() { Console.WriteLine("Mammal Eat"); }
}

class Dog : Mammal
{
    public new void Eat() { Console.WriteLine("Dog Eat"); }       // hiding   // new 는 새로운 메서드 생성
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
        Mammal mammal = new Dog();
        mammal.Eat();

        Dog dog = new Dog();
        dog.Eat();
    }
}