class Program
{
    static int Add(int x, int y) { return x + y; }
    //(int x, int y) => {return x + y;} // 더하는 기능, 람다식, 절
    //(int x, int y) => x + y           // 더하는 기능, 람다식, 식
    //(x, y) => x + y                   // 더하는 기능, 람다식, 식

    delegate int Del(int x, int y);

    static void Main(string[] args)
    {
        Del del = Add;
        Del del1 = (a, b) => a + b; Console.WriteLine(del1(2, 3));
        del = (a, b) => a - b; Console.WriteLine(del(2, 3));
        del = (a, b) => a * b; Console.WriteLine(del(2, 3));

        Del add = (a, b) => a + b;
        Del sub = (a, b) => a - b;
        Del mul = (a, b) => a * b;
        Del div = (a, b) => a / b;

        //var func = (a, b) => a + b;
        var func = (int a, int b) => a + b;     // 자료형 명시
    }
}