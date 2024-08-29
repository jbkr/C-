//https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/

//최신 비동기 닷넷 애플리케이션은 async 와 await
//
//      두 가지 키워드를 사용하여 비동기 프로그래밍을 표현

//메서드 선언에 추가하는 async 키워드 ***
//      메서드 안에서 await 키워드를 사용할 수 있게 하고,
//      컴파일러에 해당 메서드의 상태 머신을 생성하라고 지시.

//async 메서드는
//      값을 반환해야 할 때는 Task를 반환하고, ***
//      값을 반환하지 않을 때는 Task 또는 ValueTask 같은 유사 Task 형식을 반환
//      열거형에 속하는 여러 값을 반환해야 할 때 IAsyncEnumerable<T> 나 IAsyncEnumerator<T> 를 반환할 수 있다.

using System;
using System.Threading.Tasks;

//동기 //비동기 -----------------------------------------------------------
/*
    //실행할 메서드 -------------------------------
    static void Doit() 
    {
        Thread.Sleep(2000);
        Console.WriteLine("Doit");
    }

    //비동기로 구성 ------------------------------
    static async void DoitAsync()           //async
    {
        await Task.Run(() => Doit());       //await
    }

    static void Main(string[] args)
    {
        Console.WriteLine("start");

        Doit();                             //동기

        DoitAsync();                        //비동기

        Console.WriteLine("done");
        Console.ReadLine();
    } 
*/

namespace Async
{
    class MainApp
    {
        async static void MyMethodAsync(int count)  //async 비동기 수행
        {
            Console.WriteLine("start");
            await Task.Run(() =>                    //await 에서 반환
            {
                for (int i = 1; i <= count; i++)
                    Thread.Sleep(1000);
            });
            Console.WriteLine("end");
        }

        static void Main(string[] args)
        {
            MyMethodAsync(5);

            Console.WriteLine("main");

            Console.ReadLine();
        }

    }
}

/*
    async static private void MyMethodAsync(int count)  //async 비동기 수행
    {
        //Console.WriteLine("MyMethodAsync s");
        await Task.Run(
            async () =>                                 //람다 비동기 실행
            {
                for (int i = 1; i <= count; i++)
                {
                    await Task.Delay(1000);
                    //Console.WriteLine("Delay");
                }
            });
        //Console.WriteLine("MyMethodAsync e");
    }

    static void Caller()
    {
        //Console.WriteLine("Caller s");
        MyMethodAsync(3);
        //Console.WriteLine("Caller e");
    }

    static void Main(string[] args)
    {
        Caller();

        Console.ReadLine(); // 프로그램 종료 방지
    } 
 
*/


