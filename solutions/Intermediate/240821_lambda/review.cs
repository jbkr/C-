class Class
{
    public string Name { get; set; }
    public int[] Score { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Class[] classes =
        {
            new Class(){Name="연두반",Score=new int[]{99,80,70,24}},
            new Class(){Name="분홍반",Score=new int[]{60,45,87,72}},
            new Class(){Name="파랑반",Score=new int[]{92,30,85,94}},
            new Class(){Name="노랑반",Score=new int[]{90,88,0,17}}
        };

        var output = from c in classes
                     from s in c.Score
                     where s < 60
                     orderby s
                     select new
                     {
                         Name = c.Name,
                         Lowest = s
                     };

        foreach (var item in output)
        {
            Console.WriteLine($"Name: {item.Name} Score: {item.Lowest}");
        }


    }

}