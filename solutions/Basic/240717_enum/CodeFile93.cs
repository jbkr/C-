class Program
{
    static int[] intArray = new int[3];
    static object[] objArray= new object[3];
    static void Main(string[] args)
    {
        Add(100);
    }

    private static void Add(int number)
    {
        intArray[0] = number;       // int[]
        objArray[0] = number;       // object[] 성능저하
    }

}