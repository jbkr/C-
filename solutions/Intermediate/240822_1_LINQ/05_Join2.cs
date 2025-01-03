//join 예시

using System;
using System.Linq;

class User
{
    public string Name { get; set; }
    public string Nickname { get; set; }
    public int Money { get; set; }
}

class Game
{
    public string Nickname { get; set; }
    public int Level { get; set; }
}

class MainApp
{
    static void Main(string[] args)
    {
        User[] userlist =
        {
            new User(){Name="User01", Nickname="Player01", Money=1000},
            new User(){Name="User02", Nickname="noname", Money=0},
            new User(){Name="User03", Nickname="Player02", Money=100},
            new User(){Name="User04", Nickname="Player03", Money=500},
            new User(){Name="User05", Nickname="Player04", Money=800}
        };

        Game[] gamelist =
        {
            new Game(){Nickname="Player01", Level=10},
            new Game(){Nickname="Player02", Level=1},
            new Game(){Nickname="Player03", Level=2 },
            new Game(){Nickname="Player04", Level=6}
        };

        //각 유저의 게임 플레이 레벨을 표시하세요. 

        var list =
            from a in userlist
            join b in gamelist on a.Nickname equals b.Nickname      //내부 조인
            //join b in gamelist on a.Nickname equals b.Nickname into data     //외부 조인
            //from b in data.DefaultIfEmpty(new Game() { Level = -1 })
            select new
            {
                Name = a.Name,
                Level = b.Level
            };

        Console.WriteLine("--- 내부 조인 결과 ---");
        foreach (var item in list)
        {
            Console.WriteLine("user:" + item.Name + " level:" + item.Level);
        }
    }
}