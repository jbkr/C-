class Program
{
    static void Main(string[] args)
    {
        Func<int, int> increase = n => n + 1;       // 미리 정의된 delegate  => 따로 선언할 필요가 없다

        var f = (int n) => n + 1;                   // 입력 type 명시

        Func<int, int> func = (int a) => { return 1; };
    }
}