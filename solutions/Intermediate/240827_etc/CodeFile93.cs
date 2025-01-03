// async, await - 비동기
// 폴링 방식 - 주기적 확인
// 콜백 방식 - task
// async - 한정자 - 비동기 처리 선언
// await - 비동기 처리 부분 표시 ( *** )

class Program
{
    static void Doit()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Doit");
    }

    static async void DoitAsync()           // 2. async 한정자를 붙인다    -> 기존 코드를 아주 쉽게 비동기로 전환
    {
        await Task.Run(() => Doit());       // 1. 비동기 코드를 await로 감싼다 -> Task task = Task.Run... 대신 처리
    }

    static void Main(string[] args)
    {
        Console.WriteLine("start");
        Doit();
        DoitAsync();
        Console.WriteLine("done");
        Console.ReadLine();
    }
}