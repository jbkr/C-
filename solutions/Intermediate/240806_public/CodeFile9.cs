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

    }
}