class Program
{
    //static void divide(int a, int b, ref int quotien, ref int remainder)
    static void divide(int a, int b, out int quotien, out int remainder)
    {
        quotien = a / b;      // error
        remainder = a % b;    // error
    }

    static void Main(string[] args)
    {
        //int q = 0;
        //int r = 0;
        //divide(10, 3, out q, out r);
        divide(10, 3, out int q, out int r);
        Console.WriteLine(q + " " + r);


    }

}