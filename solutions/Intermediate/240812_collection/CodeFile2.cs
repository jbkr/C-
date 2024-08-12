using System;

class Program
{
    class Player
    {
        public string Nickname { get; set; }
        public int Level { get; set; }
        public void LevelUp()
        {
            //throw new MyException("Player Exception");
            throw new MyException() { Nickname = this.Nickname, Level = this.Level };
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Player player = new Player() { Nickname = "Hero", Level = 3 };
            player.LevelUp();
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.Nickname);
            Console.WriteLine(ex.Level);
        }
    }

    // customised exception
    class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public string Nickname { get; set; }
        public int Level { get; set; }
    }
}
