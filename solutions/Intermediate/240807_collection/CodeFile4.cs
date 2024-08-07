// 가변 배열
// 배열이 여러 개
// int[][] jagged = new int[3][];   사이즈가 다른 배열 3개

// 동적 배열
// collection - 자료 구조

class Program
{
    static void Main(string[] args)
    {
        int[][] jarr = new int[2][];
        jarr[0] = new int[3] { 1, 2, 3 };
        jarr[1] = new int[2] { 10, 20 };

        int[][] jarr2 = new int[2][]
        {
            new int[3]{1,2,3 },
            new int[2]{10,20 }
        };

        for (int i = 0; i < jarr.Length; i++)
        {
            for (int j = 0; j < jarr[i].Length; j++)
            {
                Console.Write(jarr[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 더 간단
        foreach (var arr in jarr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}