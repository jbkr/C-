class Program
{
    static void Print(string name, string phone)
    {
        Console.WriteLine(name + " " + phone);
    }

    static void Main(string[] args)
    {
        Print("Kim", "010-1111-2222");
        Print(name: "Kim", phone: "010-1111-2222");     // 명명된 매개 변수(named parameter)
        Print(phone: "010-1111-2222", name: "Kim");     // 바뀐 순서
        // 가독성에 도움을 준다.
    }
}