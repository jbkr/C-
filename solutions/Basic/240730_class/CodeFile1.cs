// class
// 관련된 데이터를 하나로 묶음 -> 캡슐화

// 플레이어(object) - (int x,int y) 이동 (void Move())
enum Dir
{
    LEFT,
    RIGHT,
    UP,
    DOWN
}

class Monster
{
    int x;
    int y;
    Dir dir;        // L,R,U,D

    public void Move()
    {
        if (dir == Dir.LEFT) x--;
        if (dir == Dir.RIGHT) x++;
    }

    public void SetDir(Dir d)
    {
        this.dir = d;
    }

    public void Render()
    {
        Render render = new Render(this);
        // render와 관련된
        // 절차지향적
        // 코드
        // ==> 코드는 간결하고 보기 쉽게
    }
}

class Render
{

}


class Player
{
    int x;
    int y;
    Dir dir;        // L,R,U,D

    public Player(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move()
    {
        if (dir == Dir.LEFT) x--;
        if (dir == Dir.RIGHT) x++;
    }

    public void SetDir(Dir d)
    {
        this.dir = d;
    }
}

class Battle
{
    public void Skill(Player p, Monster m)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.SetDir(Dir.LEFT);
        player.Move();

        Monster monster = new Monster();
        monster.SetDir(Dir.RIGHT);
        monster.Move();

        Battle battle = new Battle();
        battle.Skill(player, monster);

    }
}