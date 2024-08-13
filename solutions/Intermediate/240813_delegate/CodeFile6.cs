// 익명 메서드
// 형식 선언
// 두 가지 다름

class Program
{
    //void () { }
    //delegate (){}
    delegate int Del(int a, int b);

    static int Add(int a, int b) { return a + b; }

    static void Main(string[] args)
    {
        //Del del = Add;
        // delegate (   ) {     }   // 익명 메서드   // 선언 없이 간단하게 사용
        Del del = delegate (int a, int b) { return a + b; };    // 람다로 대체
        int n = del(1, 2);
    }
}