// 컴퓨터가 임의의 수를 생성하면
// 알아 맞추는 프로그램을 작성하세요
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int number = 0;                     // 컴퓨터가 만드는 임의의 수

        Random random = new Random();
        number = random.Next() % 100 + 1;   // 1~100

        Console.WriteLine(number);          // test

        while (true)
        {
            Console.WriteLine("숫자를 맞추세요(1~100)");
            int num = 0;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                count++;
                // 비교
                if (num == number)
                {
                    Console.WriteLine("success");
                    Console.WriteLine("당신은 " + count + "만에 성공했습니다.");
                    break;
                }
                else if (num > number)
                {
                    Console.WriteLine("더 작아요");
                }
                else
                {
                    Console.WriteLine("더 커요");
                }
            }
        }
    }
}