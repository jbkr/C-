// optional parameter
class Program
{
    static void Sum(int n1, int n2 = 2)
    {
        Console.WriteLine(n1 + n2);
    }

    static void PlaySound(string soundName, float volume = 1.0f) { }

    static void Main(string[] args)
    {
        Sum(1);         // 3
        Sum(1, 2);      // 3

        PlaySound("bgsound", 0.5f);     // 출력:      이름: bgsound, 볼륨: 0.5f
        PlaySound("bgsound");           // 출력:      이름: bgsound, 볼륨: 1.0f
    }
}