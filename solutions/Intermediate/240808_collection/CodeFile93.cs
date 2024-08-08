class Program
{
    static void Main(string[] args)
    {
        // 1 2 3 4 5

        List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
        ints.Insert(2, 100);        // 2번 앞에 100 추가
        //ints.Add(1);
        //ints.Add(2);
        //ints.Add(3);
        //ints.Add(4);
        //ints.Add(5);

        //ints.Remove(1);
        //ints.RemoveAt(0);

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(ints.Contains(100));
        Console.WriteLine(ints[0]);
        Console.WriteLine(ints.Count);

        ints.Find(i => i == 1);     // lambda
        ints.RemoveAll(a => a > 3);

        ints.Sort();
        ints.Reverse();
    }
}