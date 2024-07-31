// 상속 및 오버라이드 금지
// sealed(봉인된)
// C++의 final

sealed class Parent
{

}

class Parent1
{
    public virtual void Method() { }
}

//class Child : Parent      // 상속 금지
class Child : Parent1
{
    //public override void Method() { }
    public sealed override void Method() { }        // 더 이상 오버라이딩 금지
}

class Child1 : Child
{
    public override void Method() { }       // override 불가
}

class Program
{
    static void Main(string[] args)
    {

    }
}