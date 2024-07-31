using System.Collections;

class PlayerManager
{
    static PlayerManager? instance;
    private PlayerManager() { }
    public static PlayerManager Instance()
    {
        if (instance == null)
        {
            instance = new PlayerManager();
        }
        return instance;
    }
    Player[] players = new Player[100];
    public void Add(Player player)
    {
        int index = 0;
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i] == null)
            {
                index = i;
                break;
            }
        }
        players[index] = player;
    }
    public void Remove(string name)
    {
        Player? player = Find(name);
        //int index=players.
    }
    public Player? Find(string name)
    {
        foreach (Player item in players)
        {
            if (item.Name.Equals(name))
            {
                return item;
            }
        }
        return null;
    }
    public void Show()
    {
        foreach (Player item in players)
        {
            item?.ShowInfo();
        }
    }
    public void KK()
    {

    }
}

class Position
{
    int x;
    int y;
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

class Player
{
    string name;
    int level;
    Position position;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public Player(string name, int level, Position position)
    {
        this.name = name;
        this.level = level;
        this.position = position;
    }
    public void LevelUp()
    {
        this.level = 0;
    }
    public void Move()
    {

    }
    public void ShowInfo()
    {
        Console.WriteLine($"Player name: {name}, Player level: {level}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PlayerManager.Instance().Add(new Player("Superman", 1, new Position(0, 0)));
        PlayerManager.Instance().Add(new Player("Ironman", 2, new Position(5, 10)));
        PlayerManager.Instance().Add(new Player("Spiderman", 5, new Position(10, 10)));

        PlayerManager.Instance().Show();

        Player? player = PlayerManager.Instance().Find("Superman");
        player?.ShowInfo();

    }
}