
class Program
{
    static int[] GetNumberArr()
    {
        int[] array = { 10, 20, 30 };
        return array;
    }

    static IEnumerable<int> GetNumber()
    {
        yield return 10;
        yield return 20;
        yield return 30;
    }

    static void Main(string[] args)
    {
        foreach (int num in GetNumberArr()) // { 10, 20, 30 }
        {
            Console.WriteLine(num);
        }

        foreach (int i in GetNumber())      // 10   // 20   // 30   // 지연 실행    // F11 로 디버깅
        {
            Console.WriteLine(i);
        }
    }
}