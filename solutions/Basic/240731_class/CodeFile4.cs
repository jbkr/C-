// 상속
// 무기 -> 칼, 활, 총
// 추상화
// 부모클래스의 코드를 재활용 -> 코드 중복 해결 -> 코드 양이 줄어든다
class Animal { }

class Cat : Animal { }      // Cat is a Animal ( is-a )

class Weapon
{
    public Weapon() { }         // 기본 생성자 별도 작성
    public Weapon(int power)
    {
        this.power = power;
    }
    protected int power;        // 공격력
    public void PowerUp()
    {
        power++;
    }
    public void Attack() { }    // 공격하기
}

class Knife : Weapon
{
    // 매개변수 생성자 추가 시 기본 생성자는 자동 생성되지 않는다
    public Knife(int power) : base(power) { }
}

class Bow : Weapon
{
    public Bow(int power, int reach) : base(power) { }
    private int reach;          // 도달거리
    public void BowUp()
    {
        reach++;
    }
}

class Gun : Weapon
{
    private int magazine;       // 탄창
    public void Reload() { }    // 재장전하기
}

class Program
{
    static void Main(string[] args)
    {
        Bow bow = new Bow(100, 10);
    }
}