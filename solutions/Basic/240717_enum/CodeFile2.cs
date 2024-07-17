class Program
{
    readonly int num;       // 생성자에서 초기화한 후 변경하지 않겠다.

    Program()
    {
        num = 100;
    }
    static void Main(string[] args)
    {
        const int a = 3;            // 변경하지 않겠다
        // a=4;                     // error

        const double PI = 3.14;     // symbolic constants ( 상수화 )
        const string name = "James";
    }

}
