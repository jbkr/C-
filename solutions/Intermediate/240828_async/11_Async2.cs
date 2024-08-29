//Task 반환을 통한 중첩 호출

//await를 적용하려면 비동기 함수로 바꿔야 한다.

//async를 적용하기
//  반환 형식이 void인 메서드가 있을 때,           void를 Task 로 바꾸고 async를 적용
//  반환 형식이 void가 아닌 메서드를 비동기화할 때, T를 Task<T> 로 바꾸고 async를 적용

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UsingTask
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Go();
            Console.WriteLine("Main");

            Console.ReadLine(); // 프로그램 종료 방지
        }

        //Task를 돌려주는 비동기 함수  -----------------------------------------------
        //  반환 형식이 void인 메서드가 있을 때, void를 Task로 바꾸고 async를 적용하면 
        //  메서드 자체가 await를 적용할 수 있는 유용한 비동기 버전으로 변한다. 

        async static Task PrintAnswerToLife()  // Task를 돌려준다.
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            Console.WriteLine(answer);
        }

        //이 덕분에 비동기 호출 연쇄(비동기 함수 안에서 다른 비동기 함수를 호출하는)를 사용하기가 어렵지 않다.
        async static Task Go()
        {
            await PrintAnswerToLife();
            Console.WriteLine("Done");
        }
/*
        //Task<T>를 돌려주는 비동기 함수 ------------------------------------
        //  반환 형식이 void가 아닌 메서드를 비동기화할 때

        async static Task<int> GetAnswerToLife()
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            return answer;
        }
        async static Task PrintAnswerToLife()
        {
            int answer = await GetAnswerToLife();       //
            Console.WriteLine(answer);
        }
        async static Task Go()
        {
            await PrintAnswerToLife();
            Console.WriteLine("Done");
        }
*/
    }

}


/*
//await 와 Task Result 비교
//    await는 비동기 대기,
//    Task의 Result는 동기 대기를 하게 됩니다.

//    비동기 메소드는 결과 값을 얻기까지의 소요시간이 예상할수 없거나, 
//    오래 걸리는 작업에 사용하면 유용하다고 보시면 됩니다. 
//    그러므로 Result보다는 await로 정확히 비동기 대기로 기다리시는 것을 권합니다.

동작도 상이합니다. 
    await의 경우 결과 값을 받기 까지 대기하는것은 Result와 동일하지만, 스레드 상태가 달라집니다. 
    await로 인해 값을 받기까지의 대기는, 진입 스레드에 있지 않습니다. 
    이 동작을 확실하게 눈으로 확인하시려면 Windows Forms이나 WPF 등 UI에서 비동기 메소드를 호출해 보시면 됩니다.
    Result의 경우 호출 스레드가 값이 반환될 때까지 대기하는데 반해, 
    await로 비동기 대기하는 경우, 호출 스레드는 자신의 스레드 흐름으로 넘어가 화면이 계속적으로 반응합니다.
*/
//https://gist.github.com/ghuntley/e5b5642ecc4428255e61185bb79856e4


//await는 Task와 같은 awaitable 클래스의 객체가 완료되기를 기다리는데,
//      중요한 점은 await 키워드를 만나면 
//      UI 쓰레드가 정지되지 않고 메시지 루프를 계속 돌 수 있도록,
//      필요한 코드를 컴파일러가 자동으로 추가한다는 점 ***

/*
    // 예제1
    private void button1_Click(object sender, EventArgs e)
    {
         Run();  //UI Thread에서 실행
    }

    private async void Run()
    {
        // 비동기로 Worker Thread 에서 도는 task1   // Task.Run(): .NET Framework 4.5+  ***
        var task1 = Task.Run(() => LongCalcAsync(10));  

        // task1이 끝나길 기다렸다가 끝나면 결과치를 sum에 할당
        int sum = await task1;

        // UI Thread 에서 실행
        // Control.Invoke 혹은 Control.BeginInvok 필요없음
        this.label1.Text = "Sum = " + sum;
        this.button1.Enabled = true;
    }

    private int LongCalcAsync(int times)
    {
        int result = 0;
        for (int i = 0; i < times; i++)
        {
            result += i;
            Thread.Sleep(1000); 
        }
        return result;
    } 
*/

// C# 5.0과 함께 선보인 .NET 4.5는 기존의 동기화(Synchronous) 메서드들과 구분하여
// C#의 await (혹은 VB의 Await)를 지원하기 위해 많은 Async 메서드들을 추가하였다
/*
    System.IO.Stream.Read() : 기존 동기 메서드
    System.IO.Stream.ReadAsync() : 4.5 Async 메서드

    WebClient.DownloadStringAsync() : 기존 비동기 메서드
    WebClient.DownloadStringTaskAsync() : 4.5 TaskAsync 메서드
*/


//await : UI 쓰레드에서 Task
//  await가 기다리는 Task는 대부분의 경우 Background Worker Thread에서 실행된다.
//  하지만 await를 썼다고 해서 자동으로 그 Task(혹은 메서드)가 Worker Thread에서 도는 것은 아니다.
//  만약 Worker Thread를 생성하려면, Task.Run() 등과 메서드를 사용하여 비동기 작업을 지정할 수 있다.
/*
    private void button1_Click(object sender, EventArgs e)
    {
         Run();  //UI Thread에서 실행
    }
    private async void Run()
    {    
        int sum = await LongCalc2(10);      //
        this.label1.Text = "Sum = " + sum;
        this.button1.Enabled = true;
    }
    private async Task<int> LongCalc2(int times)
    {
        //UI Thread에서 실행
        Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
        int result = 0;
        for (int i = 0; i < times; i++)
        {
            result += i;                
            await Task.Delay(1000);
        }
        return result;
    }
 
*/

//await : Task.ContinueWith()
//await는 해당 Task가 끝난 후 await 문장이 있었던 곳으로부터 계속 다음 문장들을 실행하도록 되어있다.
//이러한 기능은 .NET 4.0에서 소개 되었던 Task클래스의 ContinueWith()를 사용한 것과 동일한 방식
/*
    private void Run2()
    {
        var task1 = Task<int>.Run(() => LongCalc2(10));

        // await task1 과 동일한 효과
        
        task1.ContinueWith(x => {
            this.label1.Text = "Sum = " + task1.Result;
            this.button1.Enabled = true;
        }, TaskScheduler.FromCurrentSynchronizationContext());
    }
*/