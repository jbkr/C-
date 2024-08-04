interface IMove
{
    void Move();
}

interface IRender
{
    void Render();
}

class Gimmick : IMove, IRender
{
    public void Move() { }

    public void Render() { }
}

class Player : IMove, IRender
{
    public int hp = 0;

    public void Move() { }

    public void Render() { }
}

class Hero : Player
{
    public override void Move()
    {
        throw new NotImplementedException();
    }
}

class Monster : Player
{
    public override void Move()
    {
        throw new NotImplementedException();
    }
}

class NPC : Player       // non player character
{
    public override void Move()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player[] arr = { new Hero(), new Monster(), new NPC() };

        List<Player> list = new List<Player>();         // 가변 배열 ( C++ vector )     // 정의
    }
}