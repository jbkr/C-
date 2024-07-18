class Program
{
    class Animal { }
    class Dog : Animal { }
    static void Main(string[] args)
    {
        Type type = typeof(int);        //1.GetType()
        Console.WriteLine(type.Name);

        Dog dog = new Dog();
        Console.WriteLine(dog.GetType());

        Animal spot = new Dog();
        Console.WriteLine(spot.GetType());  // Object 상속 => GetType 메서드
        Console.WriteLine(spot is Animal);
    }
}