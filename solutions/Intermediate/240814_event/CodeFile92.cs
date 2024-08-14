class Program
{
    static void Main(string[] args)
    {
        // 10보다 큰 숫자 찾아 배열에 저장
        int[] arr = { 12, 2, 3, 5, 7 };

        int[] arr2= Array.FindAll(arr, n => n > 10);
        foreach(var item in arr2)
        {
            Console.WriteLine(item);
        }
    }
}