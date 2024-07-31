// type casting

class Mammal
{
    public void Nurse() { }
}

class Dog : Mammal
{
    public void Bark() { }
}

class Cat : Mammal
{
    public void Meow() { }
}

class Program
{
    static void Main(string[] args)
    {
        Mammal mammal = new Dog();      // upcasting
        //Dog dog = new Mammal();       // downcasting    // error  // 없는 정보에 접근 // 메모리 침법 // 다운
        Dog dog = (Dog)new Mammal();    // 명시적 형변환      // 실행하면 다운된다

        Dog dog1 = (Dog)mammal;         // 원래대로 형 변환하는 경우는 괜찮다
    }
}