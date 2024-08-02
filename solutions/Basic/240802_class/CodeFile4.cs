class Program
{
    abstract class Base
    {
        public abstract void Message();     // abstract // 반드시 상속해서 오버라이드해라
    }

    interface IBase
    {
        void Message();
    }

    class CBase : IBase
    {
        public void Message()
        {

        }
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

        //IBase i = new IBase();        // 객체 생성 불가
        IBase ib = new CBase();
        ib.Message();
    }
}