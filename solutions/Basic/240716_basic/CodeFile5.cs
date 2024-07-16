class Program
{
    static void Main(string[] args)
    {
        string s = "100";
        int num = int.Parse(s);

        int num2 = Convert.ToInt32(s);
        short s1 = Convert.ToInt16(s);
        long s2 = Convert.ToInt64(s);
        double s3 = Convert.ToDouble(s);
        float s4 = Convert.ToSingle(s);

        // 100 -> "100"
        string s5 = num.ToString();

        string s6 = num + "";
    }
}