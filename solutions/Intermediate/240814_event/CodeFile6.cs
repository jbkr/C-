class Program
{
    // 문자열을 모두 더해서 반환

    delegate string AddString(string[] arr);
    static void Main(string[] args)
    {
        string[] strs = { "abc", "def" };

        AddString addString = (strs) =>
        {
            string s = "";
            foreach (var item in strs)
            {
                s += item;
            }
            return s;
        };

        Console.WriteLine(addString(strs));
    }
}