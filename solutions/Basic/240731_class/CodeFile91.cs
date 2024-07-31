class Mammal
{
    public void Nurse() { Console.WriteLine("Nurse()"); }
    public virtual void Eat() { Console.WriteLine("Mammal"); }
}

class Dog : Mammal
{
    public override void Eat() { Console.WriteLine("Dog"); }
    public void Bark() { Console.WriteLine("Bark()"); }
}

class Cat : Mammal
{
    public override void Eat() { Console.WriteLine("Cat"); }
    public void Meow() { Console.WriteLine("Meow()"); }
}

class Program
{
    static void Main(string[] args)
    {
        Mammal mammal = new Cat();
        mammal.Eat();
    }
}