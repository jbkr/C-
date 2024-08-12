class Program
{
    class A { }

    //int B(int a);
    delegate int B(int a);  // B 라는 delegate 형식 ( int 를 입력받아 int 를 반환하는 형식 )      // 1)

    static int Func(int a) { return a; }                // 2)
    static int Func2(int a) { return a; }                // 2)
    static int Func3() { }                // 2)

    static void Main(string[] args)
    {
        A a = new A();
        //B b = new B( 함수 );
        //B b = new B(Func);                            // 3)
        B b = Func;           // 델리게이트 객체에 함수를 담고
        b(1);                 // b 라는 델리게이트 객체는 함수처럼 사용

        B b2 = Func2;
        //B b3 = Func3;   // Error - 형식이 안 맞음
    }
}