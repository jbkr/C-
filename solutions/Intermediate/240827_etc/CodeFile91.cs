// Parallel

class Program
{
    static void SomeMethod(int i)
    {
        Console.WriteLine(i);
    }

    static void Main(string[] args)
    {
        //Parallel.For(0, 100, SomeMethod);   // 자동
        Parallel.For(0, 100, (i) => { Console.WriteLine(i); });


    }
}