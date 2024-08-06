// 식 본문 정의 ( Expression-bodied member ) " => "

class MyClass
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value;
    }

    public MyClass(string name) => Name = name;

    int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    int Add1(int a, int b) => a + b;
}

class Program
{
    static void Main(string[] args)
    {

    }
}