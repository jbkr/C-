using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = null;    // string : reference type
        object o = null;    // string : reference type

        string s1 = "C#";
        string s2 = "Programming";

        char c = s2[0]; Console.WriteLine(c);
        //s2[0] = 'p';        // read-only

        StringBuilder sb = new StringBuilder();     // 개별 접근 가능
        string s3 = s1 + s2; Console.WriteLine(s3);
        string s4 = s2.Substring(1, 3); Console.WriteLine(s4);
        string s5 = s2.Replace("Pro", "PRO"); Console.WriteLine(s5);
        s2.Remove(3);               // 새로운 문자열 반환
        Console.WriteLine(s2);      // 문자열은 변하지 않는다

        string str = "Hello".Remove(3);
        Console.WriteLine("    AAASAS   ".Trim());
        Console.WriteLine("12345".Length);

        string s10 = "12345";
        for (int i = 0; i < s10.Length; i++)
        {
            Console.WriteLine(s10[i]);
        }
    }
}