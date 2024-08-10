
class Program
{
    // Enum
    public enum FRUIT { APPLE, BANANA, PEAR, ORANGE };

    static void Main(string[] args)
    {
        FRUIT f = FRUIT.APPLE;
        Console.WriteLine(f);

        List<string> fruits = Enum.GetNames(typeof(FRUIT)).ToList();
        foreach (var item in fruits)
        {
            Console.WriteLine(item);
        }
    }
}