
class Program
{

    static void Main(string[] args)
    {
        int[] arr = { 12, 2, 3, 5, 7 };

        int[] arr2 = Array.FindAll(arr, a => a > 10);

        foreach (int i in arr2)
        {
            Console.WriteLine(i);
        }
    }
}