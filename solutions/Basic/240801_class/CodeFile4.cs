// 1개 이상의 추상함수( abstract method )를 가지고 있는 클래스 -> 추상클래스 ( abstract class )
// 인스턴스화할 수 없는 미완성 클래스

class Parent
{
    public void Method() { }
}

class Child : Parent
{
    public void Method() { }        // new 생략
}

class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Parent();
        parent.Method();

        Child child = new Child();
        child.Method();     // 본인 거 호출

        Parent parent1 = new Child();
        parent1.Method();   // Parent


    }
}