class Program
{
    static void Main(string[] args)
    {
        // operator
        int hp_cur = 500;
        int hp_max = 1000;

        // 0.0 ~ 1.0
        float value = (float)hp_cur / hp_max;       // 소수점 출력 => 형 변환

        int a = 10;
        a = a + 1;      // 11

        ++a;            // 12
        a++;            // 13

        int result = 123 + 456;             // 산술 연산자
        string re = "123" + "456";          // 문자열 결합 연산자
        Console.WriteLine(re);

        Console.WriteLine(123+"456");
        Console.WriteLine('0'+'1');         // 문자 => 유니코드 값 더하기 => 97
        Console.WriteLine("0"+"1");         // 문자열
        Console.WriteLine((int)'0');
        Console.WriteLine((int)'1');
    }
}