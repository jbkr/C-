// 
class Program
{
    static void Main(string[] args)
    {
        byte b1 = 0;        // default : unsigned   // 1 byte
        sbyte b2 = 0;

        short s1 = 0;
        ushort s2 = 0;

        int a = 0;          // default : signed
        uint b = 0;

        long l1=0;
        ulong l2=0;

        char ch = '가';      // 2 bytes ( unicode )

        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(byte.MinValue);

        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
    }
}