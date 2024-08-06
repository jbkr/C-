class Program
{
    class Box
    {
        public int X { get; set; }
        public int Y { get; set; }
        //int Size = 0;
        //public int GetSize() { return X * Y; }
        public int Size { get { return X * Y; } }   // property

        static void Main(string[] args)
        {
            Box box = new Box() { X = 10, Y = 20 };
            Console.WriteLine(box.Size);
        }
    }
}