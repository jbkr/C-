class Program
{
    static void PrintArr2D(char[,] chars)
    {
        for (int i = 0; i < chars.GetLength(0); i++)
        {
            for (int j = 0; j < chars.GetLength(1); j++)
            {
                Console.Write(chars[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        char[,] chars = new char[2, 3]
        {
            {'a','b','c' },
            {'d','e','f' }
        };

        PrintArr2D(chars);
    }
}