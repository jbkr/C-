class Order
{
    public string Customer_ID { get; set; }
    public int Order_ID { get; set; }
    public DateTime Order_Date { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var orders = new Order[]
        {
            new Order(){Customer_ID="FRANS",Order_ID=1000},
            new Order(){Customer_ID="FRANS",Order_ID=1001 },
            new Order(){Customer_ID="JAMES",Order_ID=1002 },
            new Order(){Customer_ID="JAMES",Order_ID=1003 },
        };

        // FRANS
        var v1 = orders.Where(o => o.Customer_ID.Equals("FRANS"));

        var v2 = orders.Where(o => o.Customer_ID.Equals("FRANS"))
            .Select(o => new
            {
                ID = o.Order_ID,
                DATE = o.Order_Date
            });

        var v3 = orders.Where(o => o.Order_ID == 1001).SingleOrDefault();
        var v4 = orders.Where(o => o.Order_ID == 1001).First();
        var v5 = orders.Where(o => o.Customer_ID == "FRANS").OrderBy(o => o.Order_Date);
    }
}
