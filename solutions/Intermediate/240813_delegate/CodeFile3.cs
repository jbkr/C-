// generic delegate <T>

class Program
{
    static int AscendCompare<T>(T a, T b) { return a - b; }
    static int DescendCompare<T>(T a, T b) { return b - a; }

    delegate int CompareFunc<T>(T a, T b);

    static void BubbleSort<T>(int[] array, CompareFunc<T> func)     // delegate
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - (i + 1); j++)
            {
                if (func(array[j], array[j + 1]) > 0)
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j + 1] = temp;
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