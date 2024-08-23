class Program
{
    static void Main(string[] args)
    {
        string[] fruits = { "apple", "mango", "orange" };
        string line = fruits.Aggregate((line, fruit) => line + ", " + fruit);
        Console.WriteLine(line);

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        double averageNum = numbers.Average();

        // Concat
        // 두 집합 연결하기
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var allNumbers = numbersA.Concat(numbersB);
    }
}