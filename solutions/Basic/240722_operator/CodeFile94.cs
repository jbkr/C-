// 형식 유추
class Program
{
    static void Main(string[] args)
    {
        object obj = 123;

        switch (obj)
        {
            case int i:
                Console.WriteLine("int " + i);
                break;
            case float f:
                Console.WriteLine("float " + f);
                break;
            default:
                break;
        }
    }
}