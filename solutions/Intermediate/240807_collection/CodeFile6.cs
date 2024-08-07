// ArrayList

using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();   // 10, 2, 3
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.RemoveAt(0);
        list.Insert(0, 10);

        list.Add('A');      // object ( 제네릭이 아님 )
        list.Add("abc");

        foreach (var item in list)
            Console.WriteLine(item);

    }
}