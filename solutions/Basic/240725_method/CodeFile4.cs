class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine(a + b);

        a = 2;
        b = 3;
        Console.WriteLine(a + b);

        // 함수화
        // 지역변수 => 함수 내에서만 생존, 종료 시 사라짐

        // 더하기
        // OR
        // 더하기, 출력
        // 작은 기능 단위로 함수 작성

        // 더하기 // int, int ----> int    ==> 함수 선언
        AddPrint(1, 2);
        int n = Add(2, 3);

        // *** 중복 안 되게 ***
        // 변경 시 한 곳만 변경하면 되도록 => 유지 보수
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void AddPrint(int a, int b)
    {
        Console.WriteLine(Add(a, b));
    }




}