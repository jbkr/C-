class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        int fourthLowNum =
            //(from n in numbers where n > 5 select n).ElementAt(1);
            (from n in numbers where n > 5 select n).First();

        Console.WriteLine(fourthLowNum);
    }
}