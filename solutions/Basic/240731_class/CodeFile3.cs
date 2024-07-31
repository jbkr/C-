class Base
{
    public Base() { Console.WriteLine("Base"); }
    public Base(string name)
    {
        Name = name;
    }


    protected string Name;
    public void Method() { }
}

class Derived : Base
{
    public Derived() { Console.WriteLine("Derived"); }
    public Derived(string phone, string name) : base(name)      // 부모의 생성자 호출
    {
        Phone = phone;
        //Name = name;
    }

    public string Phone;           // 추가 정보
    //public void Method() { Method(); }      // 구분이 안됨
    public void Method() { base.Method(); }
    public void Show()
    {
        Console.WriteLine(base.Name + " " + this.Phone);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Base @base = new Derived();       // base는 키워드
        Derived d = new Derived();          // Base + Derived
        //d.Phone = string.Empty;
        //d.Name = string.Empty;              // Base가 이미 포함됨     // 사용 X ( protected로 설정 -> Program class에서는 사용 불가 )
    }
}