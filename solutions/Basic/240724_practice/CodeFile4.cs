class Program
{
    static void Main(string[] args)
    {
        int x = 1;
        while (x < 50)
        {
            Console.Clear();
            Console.SetCursorPosition(x, 5);

            if (x % 3 == 0)
                Console.WriteLine(" __@");
            else if (x % 3 == 1)
                Console.WriteLine("_^@");
            else
                Console.WriteLine("^_@");

            // 100밀리초 정지하고 x를 증가
            Thread.Sleep(200);
            x++;
        }
    }
}