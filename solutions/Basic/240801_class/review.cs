class Program
{
    struct Member
    {
        public string Name;
        public int Age;
    }

    static Member Func(Member member) { return member; }

    static void Main(string[] args)
    {
        Member member;
        member.Name = "test";
        member.Age = 5;

        Member member1 = Func(member);

        var person = ("Warrior", 10);
        Console.WriteLine(person.Item1);
        Console.WriteLine(person.Item2);

        var warrior = (name: "gundam", level: 34);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.level);

        var (Name, Level) = warrior;
        Console.WriteLine(Name);
        Console.WriteLine(Level);
    }
}