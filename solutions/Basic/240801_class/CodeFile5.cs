// 부모 역할만 할 용도로 만들어진 클래스
// upcasting 용도

abstract class Parent       // 추상클래스
{
    public abstract void Method();      // 추상메서드    ( 자동으로 virtual )
}

class Child : Parent
{
    public override void Method()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        //Parent parent = new Parent();   // 객체 생성 X
        Child child = new Child();

        Parent parent = new Child();    // upcasting 용도로 만들어진 클래스
        parent.Method();
    }
}