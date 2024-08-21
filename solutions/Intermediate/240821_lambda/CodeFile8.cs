class Program
{
    static void Main(string[] args)
    {
        //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> list = new List<int>() { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

        var list2 = from x in list
                    where x % 2 == 0
                    orderby x ascending   // 정렬
                    select x;
        foreach (var x in list2) Console.WriteLine(x);
    }
}