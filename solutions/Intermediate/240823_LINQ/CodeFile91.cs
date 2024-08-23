// 수량자 Quantifiers  // Any All

class Program
{
    static void Main(string[] args)
    {
        // Any
        string[] words = { "believe", "relief", "receipt", "field" };
        bool iAfterE = words.Any(w => w.Contains("ei"));

        // All
        int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
        bool onlyOdd = numbers.All(n => n % 2 == 1);
    }
}