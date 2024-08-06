// collection
// 배열 ( array )
// 같은 형식 여러 개
// 고정 배열

class Program
{
    static void Main(string[] args)
    {
        // 1 2 3 4 5
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

        Array.Sort(arr3);
        Array.Reverse(arr3);
        Array.ForEach(arr, a => Console.WriteLine(a));

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        string[] Regions = { "서울", "경기", "부산" };
        foreach (var item in Regions)
        {
            Console.WriteLine(item);
        }

        //System.Array를 통해 처리
        Array.Sort(Regions);        // 클래스명으로 접근
        Array.Reverse(Regions);
        Array.Clear(Regions);
    }
}