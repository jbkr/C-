// queue

using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        Console.WriteLine(q.Peek());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Count);
        while (q.Count > 0)
        {
            Console.WriteLine(q.Dequeue());
        }
        Console.WriteLine(q.Contains(1));
    }
}