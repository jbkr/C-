// 데이터를 가져와서 foreach 적용
// 데이터 - IEnumerable

class Program
{
    static IEnumerable<int> GetNumber()     // IEnumerable -> GetEnumerator() 구현 -> IEnumerator ( Current, MoveNext, Reset ) 구현
    {                                       // yield -> 간결하게
        yield return 10;
        yield return 20;
        yield return 30;
    }

    static void Main(string[] args)
    {
        foreach (int i in GetNumber())
        {
            Console.WriteLine(i);
        }
    }
}