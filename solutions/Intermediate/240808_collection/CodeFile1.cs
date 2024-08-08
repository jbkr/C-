class Program
{
    DateTime[] dataCollection = new DateTime[]      // IComparable
    {
        new DateTime(2013,4,1,5,10,0) ,  // 2013.4.1 5:10a
        new DateTime(2013,4,15,5,10,0),
        new DateTime(2013,4,30,5,10,0),
        new DateTime(2013,5,1,5,10,0)
    };

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Print("4/1/2013", "4/30/2013");
    }

    void Print(string strDate1, string strDate2)      // string -> DateTime
    {
        DateTime startDate = Convert.ToDateTime(strDate1);
        DateTime endDate = Convert.ToDateTime(strDate2);

        foreach (var item in dataCollection)
        {
            if (item >= startDate && item <= endDate)
            {
                Console.WriteLine(item);
            }
        }
    }
}