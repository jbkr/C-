class Program
{
    static void Main(string[] args)
    {
        // operator
        int a = 10;
        Console.WriteLine(a >= 10); // True
        Console.WriteLine(a == 1);  // False
        Console.WriteLine(a != 1);  // True

        bool isJump = false;

        if (isJump) { }
        if (!isJump) { }        // 반대

        int a1 = 10;
        Console.WriteLine(a1 > 5 || ++a1 < 10);       // 앞이 참이면 뒤 조건 생략
        Console.WriteLine(a1);   // 10

        int a2 = 30;
        string result = a2 == 30 ? "참" : "거짓";       // 대입 연산 우선 순위 : 맨 끝
        /*if (a == 30) result = "참";
        else result = "거짓";*/
        Console.WriteLine(result);



    }
}