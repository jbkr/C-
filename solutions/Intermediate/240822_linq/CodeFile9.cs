// 확장 메서드

class Program
{
    static void Main(string[] args)
    {
        //Enumerable.Range(0, 100);

        var arr = new int[100];     // 0,1,2,3...99
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * i;
        }

        var rt = from i in Enumerable.Range(0, 100)
                 select i * i;

        var result = Enumerable.Range(0, 100)
            .Where(x => x <= 10)
            .Select(x => x * x);

        Enumerable.Range(0, 100)
            .Where(x => x <= 10)
            .Select(x => x * x)
            .ForEach(x => { Console.WriteLine(x); });

        result.ForEach(i => { Console.WriteLine(i); });

        foreach (int i in rt)
        {
            Console.WriteLine(i);
        }
    }
}

public static class Ex
{
    public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
    {
        foreach (var item in list) action(item);
    }
}