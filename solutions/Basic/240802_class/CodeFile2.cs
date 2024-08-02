

class Program
{
    abstract class Base
    {
        public abstract void Message();     // abstract // 반드시 상속해서 오버라이드해라
    }

    class Derived : Base
    {
        public override void Message()
        {

        }
    }

    static void Main(string[] args)
    {
        Base b = new Derived();
        b.Message();
    }
}