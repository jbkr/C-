class Program
{
    // Enum 선언
    public enum FRUIT { APPLE, PEAR, ORANGE, MANDARIN, PEACH }

    public static List<string> list = new List<string>();

    static void Main(string[] args)
    {
        FRUIT f = FRUIT.APPLE;
        f = FRUIT.PEAR;

        list = Enum.GetNames(typeof(FRUIT)).ToList();
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

    }
}