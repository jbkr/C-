using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable()
        {
            ["level"] = 10,
            ["damage"] = 200
        };

        SendData(ht);
    }

    static void SendData(Hashtable ht)
    {
        Console.WriteLine("level: " + ht["level"]);
        Console.WriteLine("damage: " + ht["damage"]);
    }
}