// player 상태 변화
// 조건식 : 정수 또는 문자열
class Program
{
    static void Main(string[] args)
    {
        int rank = 1;
        switch (rank)
        {
            case 1:
                Console.WriteLine("10000");
                break;
            case 2:
                Console.WriteLine("5000");
                break;
            case 3:
                Console.WriteLine("1000");
                break;
            default:
                Console.WriteLine("100");
                break;
        }
    }
}