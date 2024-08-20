class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product(){Name="감자",Price=500},
            new Product(){Name="사과",Price=700},
            new Product(){Name="고구마",Price=400},
            new Product(){Name="배추",Price=600},
            new Product(){Name="상추",Price=300},
        };

        foreach (Product p in products)
        {
            Console.Write(p.Name + ": " + p.Price + " ");
        }
        Console.WriteLine();

        products.Sort((a, b) => a.Name.CompareTo(b.Name));

        foreach (Product p in products)
        {
            Console.Write(p.Name + ": " + p.Price + " ");
        }
        Console.WriteLine();
    }

    static int Compare(Product p1, Product p2)
    {
        return p1.Name.CompareTo(p2.Name);
    }
}