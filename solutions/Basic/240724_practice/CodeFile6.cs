class Program
{
    static void Main(string[] args)
    {
        //
        // 입력
        int count = 0;

        // 연산
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 50 == 0)
                count++;
        }

        // 출력
        Console.WriteLine(count);

        string[] fruits = { "사과", "배", "포도" };
        for (int i = fruits.Length - 1; i >= 0; i--)
            Console.WriteLine(fruits[i]);
        foreach (var item in fruits)
            Console.WriteLine(item);

        //
        string str = "감자 고구마 토마토";
        string[] strings = str.Split(' ');
        foreach (var item in strings)
            Console.WriteLine(item);

        //
        string s = "가나다라마바사";
        char[] strings1 = s.ToCharArray();
        Array.Reverse(strings1);
        string s1 = new string(strings1);
        Console.WriteLine(s1);

        //
        List<string> list = new List<string>();
        list.Add(Console.ReadLine());
        list.Add(Console.ReadLine());
        list.Add(Console.ReadLine());
        foreach (var item in list)
            Console.WriteLine(item);
        list.Sort();
        foreach (var item in list)
            Console.WriteLine(item);

        // 함수화
        string id = Console.ReadLine();
        char[] chars = id.ToCharArray();
        bool check = true;

        // 함수화
        // isValid(s)

        // 정규표현식
        // @"^[0-9a-zA-Z]{2,100}$"

        while (check)
        {
            if (chars.Length >=2 && chars.Length <= 50) check = false;

            foreach (var item in chars)
            {
                if (item < '0' || item > '9' || item < 'a' || item > 'Z')
                {
                    check = false;
                }
            }
        }
    }
}