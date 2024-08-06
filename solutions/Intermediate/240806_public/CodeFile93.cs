class Program
{
    interface INamedValue
    {
        string Name { get; set; }       // 인터페이스에 선언 가능
        string Value { get; set; }
    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    static void Main(string[] args)
    {
        NamedValue namedValue = new NamedValue() { Name = "", Value = "" };
    }
}