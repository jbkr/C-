class Program
{
    struct Member
    {
        public string Name;
        public int Age;
    }

    Member Func(Member member) { return member; }

    static void Main(string[] args)
    {
        Member member;
        member.Name = "test";
        member.Age = 5;

        var person = ("test", 5);       // 2개의 데이터를 담는 용도       *** (  ,  ,  ,  ) ***
        //var player = ("전사", 10, 'S');
        var player = (Name: "전사", Level: 10, Grade: 'S');       // 명명된 선언

        Console.WriteLine(player.Item1);
        Console.WriteLine(player.Item2);
        Console.WriteLine(player.Item3);

        Console.WriteLine(player.Name);
        Console.WriteLine(player.Level);
        Console.WriteLine(player.Grade);

        var (name, level, grade) = player;      // 튜플 분해
        Console.WriteLine(name);
        Console.WriteLine(level);
        Console.WriteLine(grade);

        var named = (Name: "홍길동", Age: 17);
        var unnamed = ("고길동", 48);
        named = unnamed;
        Console.WriteLine(named.Name + " " + named.Age);
    }
}