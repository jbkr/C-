// Player 2명 전투
// 절차 지향 ->  ** 변수 선언, 연산, 조건, 반복, ... ( 순서 )
// 객체 지향 ->  ** 설계 부터 ( 클래스 )

// namespace 사용할 때
using MyProject;

// 클래스 이름 중복될 때
namespace MyProject
{
    class Player
    {
        int n = 0;      // private  // 서로 독립적으로 존재하도록

        // 속성
        public int hp = 100;
        public int ap = 10;

        // 행동
        //void Attack(int ap) { }
        public void Move() { }

        public void Func()
        {
            Console.WriteLine(hp);      // 외부 함수에 의해 변경될 때 경우 클래스 내 메서드가 불안해진다. ( 제어할 수가 없다 )
        }
    }
}

class Player
{
    // 속성
    public int hp = 100;
    public int ap = 10;

    // 행동
    //void Attack(int ap) { }
    public void Move() { }
}

class Battle
{
    public void Attack(Player p1, Player p2)
    {
        p2.hp -= p1.ap;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //int player1_hp = 100;
        //int player1_ap = 10;
        //int player2_hp = 200;
        //int player2_ap = 20;

        //// Attack
        //int damage = player2_hp - player1_ap;
        //player2_hp -= damage;

        Player player1 = new Player();
        Player player2 = new Player();

        //Attack(player1,player2);
        Battle battle = new Battle();
        battle.Attack(player1, player2);
        battle.Attack(player2, player1);


    }
}