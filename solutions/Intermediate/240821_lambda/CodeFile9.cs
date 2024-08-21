class Program
{
    static void Main(string[] args)
    {
        //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> list = new List<int>() { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

        // 3보다 큰 홀수 목록
        var list2 = from x in list
                    where x > 3 && x % 2 == 1
                    orderby x
                    select x;
        foreach (var x in list2) Console.WriteLine(x);

        // 2배가 되는 수 목록
        var list3 = from x in list
                    select x * 2;
        foreach (var x in list3) Console.WriteLine(x);

        // 제곱 수 목록
        var list4 = from x in list
                    select x * x;
        foreach (var x in list4) Console.WriteLine(x);

        // 글자 수 목록
        List<string> list5 = new List<string>() { "apple", "banana", "melon" };
        var list6 = from x in list5
                    select x.Length;
        foreach (var x in list6) Console.WriteLine(x);
        //IEnumerable<T>

        List<int> list7 = list6.ToList();   // 변환
        int[] array = list6.ToArray();      // 변환
    }
}