using System.Collections;

class MyEnumerator: IEnumerable     // IEnumerable GetEnumerator()
{
    int[] numbers = { 1, 2, 3, 4 };

    public IEnumerator GetEnumerator()      // IEnumerable
    {
        yield return numbers[0];
        yield return numbers[1];
        yield return numbers[2];
        //yield break;
        yield return numbers[3];
    }
}

class Program
{
    static void Main(string[] args)
    {
        var obj = new MyEnumerator();
        foreach (var item in obj)       // foreach - GetEnumerator() ***
        {
            Console.WriteLine(item);
        }
    }
}