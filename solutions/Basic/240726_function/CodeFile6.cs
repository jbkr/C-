// 로컬 함수
// 메서드 내부에서 선언
class Program
{
    public void SomeMethod()                        // 메서드 선언
    {
        int count = 0;
        SomeLocalFunction(1, 2);                    // 로컬함수 호출
        SomeLocalFunction(3, 4);

        void SomeLocalFunction(int a, int b)        // 로컬함수 선언
        {
            Console.WriteLine("{0}", ++count);
        }
    }

    static void Main(string[] args)
    {

    }
}