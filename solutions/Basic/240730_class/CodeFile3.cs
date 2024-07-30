// 객체 전달 -> 주소 전달(복사) -> 참조 형식
// 얕은 복사 -> 참조(주소)만 복사
// 깊은 복사 -> 객체 자체 복사(new 후 각 멤버 복사) unity의 clone함수

class Player
{
    public int level = 0;

    public Player(int level)
    {
        this.level = level;
    }

    public Player Clone()
    {
        Player player = new Player(1);      // 1. 새로운 객체 생성
        player.level = this.level;          // 2. 멤버 복사
        return player;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(1);
        LevelUp(player);                    // 2
        Console.WriteLine(player.level);
        Player player2 = player;            // 참조 복사 ( 객체는 하나 ) -> shallow copy -> 하나를 변경했지만 다른 것도 바뀜
        LevelUp(player2);
        Console.WriteLine(player.level);    // 3
        Player player3 = player.Clone();    // deep copy

    }

    static void LevelUp(Player player)      // 참조 복사
    {
        player.level++;
    }
}