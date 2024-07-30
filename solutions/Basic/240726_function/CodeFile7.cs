// 소문자로 변경
class Program
{
    static string ToLowerString(string input)
    {
        var arr = input.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            // arr[i] -> 소문자
            arr[i] = ToLower(arr[i]);
            //Console.WriteLine(arr[i]);
        }

        char ToLower(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return c;
            }
            return (char)(c + 32);
        }
        return new string(arr);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ToLowerString("Hello"));
        Console.WriteLine((int)'a');        // 97
        Console.WriteLine((int)'A');        // 65   = 32
    }
}