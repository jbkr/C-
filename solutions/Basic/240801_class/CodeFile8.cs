// 확장 메서드
// 클래스 확장
// 1. 코드 수정
// 2. 상속
// static class -> static method

class Program
{
    static void Main(string[] args)
    {
        int n = 2;
        n.ToString();

        // 기능(Square()) 추가하고자 할 때
        int m = n.Square();     // 2 * 2
        Console.WriteLine(m);
        Console.WriteLine(3.Square());
    }
}

public static class MyEx
{
    public static int Square(this int n)
    {
        return n * n;
    }
}