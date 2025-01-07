class Program
{
    static int AscendCompare(int a, int b) { return a - b; }
    static int DescendCompare(int a, int b) { return b - a; }

    delegate int CompareFunc(int a, int b);

    static void BubbleSort(int[] array, CompareFunc func)     // delegate
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - (i + 1); j++)
            {
                if (func(array[j], array[j + 1]) > 0)
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 3, 7, 4, 2, 10 };
        BubbleSort(array, AscendCompare);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}