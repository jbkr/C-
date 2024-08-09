using System.Collections;



class Program
{
    static IEnumerator TestIEnumerator()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }

    static void Main(string[] args)
    {
        IEnumerator enumerator = new TestIEnumerator();
    }
}