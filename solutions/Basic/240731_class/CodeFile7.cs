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

class Lion : Mammal
{

}

class Zookeeper
{
    //public void Care(Dog o) { }
    //public void Care(Cat o) { }
    //public void Care(Lion o) { }

    // item, inventory (item추가되도 inventory 변경 불필요 -> 유지 보수가 편하다)
    public void Care(Mammal o)
    {
        if (o is Dog) { }
    }
}