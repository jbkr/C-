// lambda
// 이름 없는 함수
// 람다로 대체

delegate int DelFunc(string s);

class Program
{
    static int Func(string s)
    {
        return s.Length;
    }

    static void Main(string[] args)
    {
        DelFunc del1 = Func;
        DelFunc del2 = delegate (string s) { return s.Length; };
    }
}