public class ClassA                     // C# 클래스
{
    int var1;                           // 필드 (전역변수, 초기값 0)         ** 클래스를 의미

    public int Var1                     // 속성 (프로퍼티)
    {
        get { return this.var1; }
        set { this.var1 = value; }
    }

    public ClassA()                     // 생성자(메서드)
    {

    }

    public void Method1()               // 메서드                          // 관련 함수 => 캡슐화
    {
        int localVar;                   // (로컬변수)
    }

}