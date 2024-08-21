class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 짝수
        List<int> list2 = new List<int>();
        foreach (int i in list)
        {
            if (i % 2 == 0) list2.Add(i);
        }
        list2.ForEach(i => { Console.WriteLine(i); });
        // 전형적인 패턴

        // LINQ
        var output = from item in list
                     where item % 2 == 0
                     select item;

        foreach (int i in output) Console.WriteLine(i);
    }
}