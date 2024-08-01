class Program
{
    struct Member
    {
        public string Name;
        public int Age;

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print() { }
    }

    static void Main(string[] args)
    {
        //Member member = new Member();
        Member member;                  // stack ( value type )
        member.Name = "test";
        member.Age = 5;

        Member member2 = member;        // ** deep copy
        member2.Age = 10;
        Console.WriteLine(member.Age);

        DateTime dt;
    }
}