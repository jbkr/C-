interface IMove { void Move(); }
interface IRender { void Render(); }
class Player : IMove, IRender
{
    public virtual void Move()
    {
        Console.WriteLine("Player Move");
    }

    public virtual void Render()
    {
        Console.WriteLine("Player Render");
    }
}

class Monster : Player
{
    public override void Move()
    {
        Console.WriteLine("Monster Move");
    }

    public override void Render()
    {
        Console.WriteLine("Monster Render");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.Move();
        player.Render();

        Monster monster = new Monster();
        monster.Move();
        monster.Render();
    }
}