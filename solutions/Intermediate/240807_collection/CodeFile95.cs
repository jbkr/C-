// string은 Immutable -> 객체 생성 후 다시 생성 -> 느리다
// StringBuilder -> Mutable
// s[0] 접근 가능

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = string.Empty;
        for (int i = 0; i < 10000; i++)
        {
            s += i.ToString();
            // "123..."
        }
        Console.WriteLine(s);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            stringBuilder.Append(i.ToString());
        }
        Console.WriteLine(stringBuilder);
    }
}