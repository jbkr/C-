class Member : IComparable  // 암기 -> ** 사용 **
{
    public String Name = "";

    public int CompareTo(object? obj)   // 암기
    {
        Member? other = obj as Member;
        return this.Name.CompareTo(other?.Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Member[] members = new Member[3];
        members[0] = new Member() { Name = "홍길동" };
        members[1] = new Member() { Name = "강감찬" };
        members[2] = new Member() { Name = "이순신" };

        Array.Sort(members);

        foreach (Member member in members)
            Console.WriteLine(member.Name);
    }
}