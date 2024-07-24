class Program
{
    static void Main(string[] args)
    {
        // 대문자화와 소문자화
        string input = "Potato Tomato";
        Console.WriteLine(input.ToUpper());
        Console.WriteLine(input.ToLower());

        Console.WriteLine("AAA".CompareTo("aaa"));      // 1
        Console.WriteLine("AAA".CompareTo("AAA"));      // 0

        if (string.Compare("StrA", "StrA", true) == 0)
        {
            Console.WriteLine("Equal");
        }

        // 부분 문자열
        string address = "서울특별시 용산구 한강로 2가";
        string case_1 = address.Substring(0, 5);
        Console.WriteLine(case_1);

        // 문자열 자르기  // Split
        string input2 = "감자 고구마 토마토";
        string[] inputs = input2.Split(" ");
        foreach (var item in inputs)
        {
            Console.WriteLine(item);
        }

        // 배열을 문자열로 // Join
        string[] array = { "감자", "고구마", "토마토" };
        Console.WriteLine(string.Join(",", array));

        // 문자열을 문자 배열로
        string s = "C# Programming";
        char[] chars = s.ToCharArray();
        foreach (var item in chars)
        {
            Console.WriteLine(item);
        }



    }
}