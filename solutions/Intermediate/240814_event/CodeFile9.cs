// 델리게이트 객체 = 람다;

class Program
{
    //static void Print(int n) { Console.WriteLine(n); }

    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //list.ForEach(Print);     // Action   // void ( int )
        list.ForEach(n => Console.WriteLine(n));    // void ( int )
        list.ForEach(n =>
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
        });
    }
}