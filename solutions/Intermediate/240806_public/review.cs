
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

        Array.Sort(arr);
        Array.Reverse(arr);
        Array.ForEach(arr, a => Console.WriteLine(a));
    }
}