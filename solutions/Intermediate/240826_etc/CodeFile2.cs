// 오리 타이핑
// 타입은 다르나 내용은 같다
// 호환성 유지

class Program
{
    class Duck
    {
        public void Walk() { }
        public void Swim() { }
        public void Quack() { }
    }

    class Mallard : Duck
    {

    }

    class Robot
    {
        public void Walk() { }
        public void Swim() { }
        public void Quack() { }
    }

    static void Main(string[] args)
    {
        dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

        foreach (dynamic duck in arr)
        {
            duck.Walk();
            duck.Swim();
            duck.Quack();
        }
    }
}