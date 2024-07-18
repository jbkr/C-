class Program
{
    static void Main(string[] args)
    {
        // 80, 74, 81, 90, 34
        //int[] scores = new int[5];
        int[] scores = { 80, 74, 81, 90, 34 };

        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine(scores[i]);
            sum += scores[i];
        }
        int average = sum / scores.Length;
        Console.WriteLine(average);
    }
}

class Test
{
    int n = 0;              // 멤버 변수, 클래스 내 전역 변수

    const float PI = 3.14f;
    readonly int MAX;
    Test()
    {
        MAX = 10;           // 객체 생성될 때 초기화
    }
    void Func()
    {
        int a = 0;          // 지역 변수
    }
}