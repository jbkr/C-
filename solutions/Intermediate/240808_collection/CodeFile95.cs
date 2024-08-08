class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic["1"] = 1;
        dic["2"] = 2;
        dic["3"] = 3;

        var scores = new Dictionary<string, int>()
        {
            {"Kim",100 },
            {"Lee",90 }
        };

        var scores2 = new Dictionary<string, int>()     // new version
        {
            ["Kim"] = 100,
            ["Lee"] = 90
        };
    }
}