class Program
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                long tick = DateTime.Now.Subtract(Birthday).Ticks;
                DateTime dateTime = new DateTime(tick);
                return dateTime.Year;
            }
        }
    }

    static void Main(string[] args)
    {
        BirthdayInfo birthdayInfo = new BirthdayInfo();
        birthdayInfo.Name = "JB";
        birthdayInfo.Birthday = new DateTime(1976,03,22);
        Console.WriteLine(birthdayInfo.Age);
    }
}