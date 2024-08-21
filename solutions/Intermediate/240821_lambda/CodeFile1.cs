// chatGPT
// lambda
// collection, generic, lambda, delegate, generic delegate
// 기본 패턴

class Program
{
    static void Main(string[] args)
    {
        List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };

        // 2보다 큰 숫자
        List<int> list3 = list2.FindAll(x => x > 2);

        // 모두 출력
        list3.ForEach(x => { Console.WriteLine(x); });

        // 4보다 작은 숫자 모두 지우세요
        list2.RemoveAll(x => x < 4);
        list2.ForEach(x => { Console.WriteLine(x); });

        // 이름순서로 정렬 출력
        List<string> list4 = new List<string>() { "item01", "enemy", "item02", "player", "item00" };
        List<string> list5 = list4.FindAll(n => n.Contains("item"));
        list5.ForEach(x => { Console.WriteLine(x); });
        list5.Sort();
        list5.ForEach(x => { Console.WriteLine(x); });
    }
}