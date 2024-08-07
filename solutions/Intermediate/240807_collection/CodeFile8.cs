// stack

using System.Collections;

class Program
{
    static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }

    static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        Console.WriteLine(s.Peek());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Count);
        //while (s.Count > 0)
        //{
        //    Console.WriteLine(s.Pop());
        //}
        //Console.WriteLine(s.Contains(1));

        PrintCollection(s);
    }
}