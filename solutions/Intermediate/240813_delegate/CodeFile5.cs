// delegate chain
// += / -=
// 동시 호출

class Program
{
    static void Call119() { Console.WriteLine("Call 119"); }
    static void ShoutOut() { Console.WriteLine("Shout out"); }
    static void Escape() { Console.WriteLine("Escape"); }

    delegate void ThereIsFire();

    static void Main(string[] args)
    {
        ThereIsFire fire = Call119;
        fire += Escape;
        fire += ShoutOut;
        fire();
        fire -= Call119;
        fire();
    }
}
