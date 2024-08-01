
class Mammal
{
    public virtual void Eat()
    {
        Console.WriteLine("Mammal");
    }
}

class Dog : Mammal
{
    public sealed override void Eat()
    {
        Console.WriteLine("Dog");
    }
}

class Puppy : Dog
{
    public override void Eat()
    {

    }
}

class Cat : Mammal
{
    public override void Eat()
    {
        Console.WriteLine("Cat");
    }
}

class Program
{
    static void Care(Mammal mammal)
    {
        mammal.Eat();
    }

    static void Main(string[] args)
    {
        Mammal[] mammals = { new Dog(), new Cat() };

        foreach (var item in mammals)
        {
            item.Eat();
        }

        Care(new Cat());

    }
}