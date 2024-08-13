// delegate

class Program
{
    //static void BubbleSort(int[] array, 함수)
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - (i + 1); j++)
            {
                if (array[j] > array[j + 1])
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
        BubbleSort(array);
        //BubbleSort(array, 함수);      
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}