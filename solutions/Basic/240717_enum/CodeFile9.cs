class Program
{
    static void Main(string[] args)
    {
        // 소숫점 2 자릿수 출력
        Console.WriteLine(1234.567.ToString("0.00"));

        // 부동소수점 오류 예시
        // 소수점이 떠다닌다
        // ==, != 연산 불가
        // 범위로 처리
        float f1 = 1.0000001f;
        Console.WriteLine(f1);
        Console.WriteLine(f1 + f1);
        Console.WriteLine(f1 + f1 + f1);
        Console.WriteLine(f1 + f1 + f1 + f1);

        //float f2 = 1513524435345.0f;

        Console.WriteLine(sizeof(char));

        // 문자를 숫자로 변환하기
        char ch = '9';
        int integer = ch - '0';
        Console.WriteLine(integer);

        int n = (int)Char.GetNumericValue(ch);
        Console.WriteLine(n);

        bool a = true;
        bool b = false;
        Console.WriteLine(a);
        Console.WriteLine(b);

        object a1 = 123;
        object b1 = 3.14;
        object c = true;
        object d = "안녕하세요";
        d = 1212;
    }

}