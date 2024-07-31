// 안전한 형변환  // is, as
// is : 캐스팅이 가능하면 true
// as : 캐스팅에 성공하면 캐스트 결과를 리턴하고, 캐스팅에 실패하면 null값을 리턴

class Mammal
{
    public void Nurse() { Console.WriteLine("Nurse()"); }
}

class Dog : Mammal
{
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
        Mammal mammal = new Dog();      // upcasting

        if (mammal is Dog)
        {
            Dog dog = (Dog)mammal;
            dog.Bark();
        }

        //Cat cat = (Cat)mammal;      // 위험
        Cat cat = mammal as Cat;
        if (cat != null)
        {
            cat.Meow();
        }
        else
        {
            Console.WriteLine("not Cat");
        }

    }
}