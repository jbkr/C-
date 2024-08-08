using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = string.Empty;
        for (int i = 0; i < 10; i++)
        {
            s += i.ToString();
        }
        Console.WriteLine(s);

        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            stringBuilder.Append(i.ToString());
        }
        Console.WriteLine(stringBuilder[0]);
    }
}
