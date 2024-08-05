class Item : IComparable
{
    public int id;
    public string name;
    public Item(int id) { this.id = id; }

    public int CompareTo(object? obj)
    {
        Item? o = obj as Item;
        return this.id.CompareTo(o?.id);
    }

    //public int CompareTo(Item other) { return id - other.id; ; }
}

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Item(1);
        Item item2 = new Item(2);
        int result = item1.CompareTo(item2);

        // item1 > item2
        //Console.WriteLine(item1.CompareTo(item2));
        int n1 = 1;
        int n2 = 2;
        int rt = n1.CompareTo(n2);      // n1 - n2
        Console.WriteLine(rt);
    }
}