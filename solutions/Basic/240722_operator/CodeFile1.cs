// null 조건부 연산자 ( ? )
// null 처리 해결
// 객체 할당 ( new )
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList a = null;
        //a=new ArrayList();

        a?.Add("야구");
        a?.Add("축구");
        Console.WriteLine($"Count : {a?.Count}");
        Console.WriteLine($"{a?[0]}");
        Console.WriteLine($"{a?[1]}");
    }
}