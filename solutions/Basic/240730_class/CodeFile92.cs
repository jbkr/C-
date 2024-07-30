// 문제
class Player
{
    string name = "";
    int level = 0;
    Position p = null;
    public Player(string name, int level, Position p)
    {
        this.name = name;
        this.level = level;
        this.p = p;
    }

    public void LevelUp()
    {
        level++;
    }

    public void Move()
    {
       
    }
}

class Position
{
    int x = 0;
    int y = 0;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Set(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class PlayerManager
{
    // singleton

    Player[] players;
    // Add
    // Remove
    // Find
}

class Program
{
    static void Main(string[] args)
    {
        //Player superman = new Player("Superman", 1, new Position(0, 0));
        //Player ironman = new Player("Ironman", 2, new Position(5, 10));
        //Player spiderman = new Player("Spiderman", 5, new Position(10, 10));

        //Player[] players = { superman, ironman, spiderman };

        Player[] players =
        {
            new Player("Superman", 1, new Position(0, 0)),
            new Player("Ironman", 2, new Position(5, 10)),
            new Player("Spiderman", 5, new Position(10, 10))
        };

        players[1].Move();
        // player manager
        // singleton

        PlayerManager playerManager = new PlayerManager();
        playerManager.Add(new Player("Superman", 1, new Position(0, 0)));

        playerManager.Instance().Add(new Player("Superman", 1, new Position(0, 0)));
    }
}