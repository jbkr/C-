// 생성자와 종료자
// 생성자 : 특별한 메서드
// 클래스명
// 반환값 X
// 오버로딩 가능 ( 매개변수 있는 생성자 )

// 종료자
// ~
// CLR(common language runtime : java vm)의 가비지 컬렉터가 종료자 호출 ( C++의 delete를 안 써도 됨 => 메모리 누수 없다 )

class Cat       // 이름, 색, 야옹울음을 운다
{
    public string name;
    public string color;

    public Cat()
    {
        name = "Name";
        color = "Red";
    }

    public Cat(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    ~Cat() { }          // C#에서는 쓸 일이 없다

    public void Meow()
    {
        Console.WriteLine("야옹");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Lion", "Gold");      // 한 줄로 => 코드는 간결하게, 짧게
    }
}