class Test
{
    public int value = 10;
}

class Program
{
    static void Func2(Test a)
    {
        a.value++;
    }

    static void Main(string[] args)
    {
        int a = 10;
        int b = a;              // value copy
        b = 20;
        Console.WriteLine(a);
        Console.WriteLine(b);

        Test testA = new Test();
        Test testB = testA;     // reference copy
        //Test testB = new Test();
        testB.value = 20;
        Console.WriteLine(testA.value);
        Console.WriteLine(testB.value);

        Func2(testB);
        Console.WriteLine(testB.value);

    }

}