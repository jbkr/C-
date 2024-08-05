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
        List<Item> list = new List<Item>();
        list.Add(new Item(2));
        list.Add(new Item(1));
        list.Add(new Item(3));

        foreach (Item item in list)
        {
            Console.WriteLine(item.id);
        }

        list.Sort();

        foreach (Item item in list)
        {
            Console.WriteLine(item.id);
        }
    }
}