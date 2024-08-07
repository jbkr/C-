// System.Array
// 2차원 배열

class Program
{
    static void Main(string[] args)
    {
        // 1 2 3
        // 4 5 6

        //int[,] arr = new int[2, 3];
        int[,] arr = new int[2, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        //arr[0, 0] = 1;
        //arr[0, 1] = 2;
        //arr[0, 2] = 3;
        //arr[1, 0] = 4;
        //arr[1, 1] = 5;
        //arr[1, 2] = 6;
        Console.WriteLine(arr[0, 2]);
        Console.WriteLine(arr[1, 0]);

        for (int i = 0; i < arr.GetLength(0); i++)          // 0번 인덱스
        {
            for (int j = 0; j < arr.GetLength(1); j++)      // 1번 인덱스
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}