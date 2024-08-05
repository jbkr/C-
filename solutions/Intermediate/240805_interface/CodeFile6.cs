using System.Collections;
using System.Collections.Generic;

class Member : IComparable  // 암기 -> ** 사용 **
{
    public String Name = "";

    public int CompareTo(object? obj)   // 암기
    {
        Member? other = obj as Member;
        return this.Name.CompareTo(other?.Name);
    }
}

class MyCompare : IComparer
{
    public int Compare(object? x, object? y)
    {
        Member? m1 = x as Member;
        Member? m2 = y as Member;
        return m1.Name.CompareTo(m2?.Name);
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

        //Array.Sort(members);                  // IComparable
        Array.Sort(members, new MyCompare());   // IComparer

        foreach (Member member in members)
            Console.WriteLine(member.Name);
    }
}