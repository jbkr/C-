class Program
{
    abstract class Product
    {
        private static int serial = 0;

        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        public abstract DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }

    static void Main(string[] args)
    {

    }
}