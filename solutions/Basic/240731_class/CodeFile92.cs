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
    static void Care(Mammal m)
    {
        m.Eat();
    }

    static void Main(string[] args)
    {
        Mammal[] list = new Mammal[] { new Dog(), new Cat() };
        foreach (var item in list)
        {
            item.Eat();

        }
        // 목록 관리가 편해진다

        Care(new Cat());
    }
}