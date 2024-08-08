// foreach
// IEnumerable - GetEnumerator()
// IEnumerator
// 내가 만든 클래스도 위 인터페이스 구현하면 foreach 쓸 수 있다

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "abc", "def" };

        foreach (var item in list)      // IEnumerable  // collection은 대부분 상속
        {
            Console.WriteLine(item);
        }
    }
}