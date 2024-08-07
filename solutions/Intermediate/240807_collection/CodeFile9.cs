// Hashtable
// key, value 쌍
// 빠른 탐색 속도 ( 키 값 해싱 -> 빠른 주소 탐색 )
// 다양한 데이터 ( 형식 제한이 없다 )

using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht[1] = "one";      // 1 one    matching
        ht[2] = "two";
        ht[3] = "three";

        Console.WriteLine(ht[2]);

        foreach (var item in ht.Keys)       // ht.Keys
        {
            Console.WriteLine(ht[item]);
        }

        foreach (var item in ht.Values)
        {
            Console.WriteLine(item);
        }
    }
}