// query(11) >> method(53)

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        // query
        var list1 = from x in list
                    where x % 2 == 0
                    select x;

        // method
        var list2 = list.Where(x => x % 2 == 0);        // 확장메서드 방식으로 구현
        foreach (var x in list2) Console.WriteLine(x);
    }
}