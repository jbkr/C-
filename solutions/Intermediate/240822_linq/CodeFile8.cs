// 확장 메서드

class Program
{
    static void Main(string[] args)
    {
        //Enumerable.Range(0, 100);

        var arr = new int[100];     // 0,1,2,3...99
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        var rt = Enumerable.Range(0, 100);   // generator

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}