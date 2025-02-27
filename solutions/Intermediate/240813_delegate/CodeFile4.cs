﻿// generic delegate <T>

class Program
{
    static int AscendCompare<T>(T a, T b) where T : IComparable<T> { return a.CompareTo(b); }
    static int DescendCompare<T>(T a, T b) where T : IComparable<T> { return a.CompareTo(b) * -1; }

    delegate int CompareFunc<T>(T a, T b);

    static void BubbleSort<T>(T[] array, CompareFunc<T> func)     // delegate
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - (i + 1); j++)
            {
                if (func(array[j], array[j + 1]) > 0)
                {
                    T temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 3, 7, 4, 2, 10 };
        BubbleSort<int>(array, AscendCompare<int>);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}