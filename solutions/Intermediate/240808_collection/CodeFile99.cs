// yield
// IEnumerable + IEnumerator
// coroutine ( 협동 루틴 - 왔다 갔다 )
// routine - 하나의 프로세스 ( 메인 루틴(main method), 서브 루틴(function) )
// yield return
// yield break

class Program
{
    static IEnumerable<int> GetNumber()
    {
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