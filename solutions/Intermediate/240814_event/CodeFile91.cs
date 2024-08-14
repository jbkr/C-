class Program
{
    static int Compare(int a, int b)
    {
        return a.CompareTo(b);
    }

    static void Main(string[] args)
    {
        int[] arr = { 12, 2, 3, 5, 7 };

        // 배열을 다루는 클래스 => Array
        Array.Sort(arr);

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Array.Sort(arr, Compare);

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Array.Sort(arr, (a, b) => a.CompareTo(b));

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Array.Sort(arr, (a, b) => b.CompareTo(a));

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}