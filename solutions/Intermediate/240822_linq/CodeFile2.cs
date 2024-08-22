﻿class Program
{
    class Player
    {
        public string Name { get; set; }
        public int x; public int y;
        public int speed = 3;
        public Player(string name, int _x, int _y)
        {
            Name = name;
            x = _x;
            y = _y;
        }

        public void Move() { x += speed; }
    }

    class PlayerManager
    {
        // Player Manager
        List<Player> players = new List<Player>();

        public PlayerManager() { }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }
        public Player? Find(string name)
        {
            return players.Find(p => p.Name.Equals(name));
        }
        public List<Player> Find2()
        {
            var players2 = from p in players
                           where p.x > 1
                           select p;
            return players2.ToList();
        }
    }

    static void Main(string[] args)
    {
        // Player Manager
        List<Player> players = new List<Player>();
        players.Add(new Player("p1", 0, 0));
        players.Add(new Player("p2", 1, 2));
        players.Add(new Player("p3", 3, 4));

        // x>1
        var players2 = from p in players
                       where p.x > 1
                       select p;
        foreach (var p in players2) Console.WriteLine(p.Name);
    }
}