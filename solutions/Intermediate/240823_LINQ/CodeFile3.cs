class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var textNums = from n in numbers
                       select strings[n];

        // "five", "four", "one"...
        var textNums2 = from n in numbers
                        select new
                        {
                            Digits = strings[n],
                            Even = (n % 2 == 0),
                        };
        // { Digits = "five", Even = false }, ...

        var textNums3 = from n in numbers
                        select (Digit: strings[n], Even: (n % 2 == 0));
        // tuple
    }
}