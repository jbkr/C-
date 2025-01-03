//Task<T> - 쓰레드 결과 리턴

// 1. new Task()
//      시작을 하지 않고 Task 객체만을 먼저 만들기 위해서는,
//      Task 클래스 생성자를 사용하여 메서드 델리게이트를 지정, Task 객체만을 생성한다.
//      생성된 Task 객체로부터 실제 쓰레드를 시작하기 위해서는 Start() 메서드를 호출하고,
//      종료때까지 기다리기 위해선 Wait() 메서드를 호출한다.
//
//  Task<int> task = new Task<int>(   )
//  task.Start();
//  task.Wait();

// 2. Task.Factory.StartNew()
//      쓰레드를 생성과 동시에 시작하는 방식
//
//  Task<int> task = Task.Factory.StartNew<int>(   )

// 3. Task.Run()
//      쓰레드를 생성과 동시에 시작

//  Task<int> task = Task<int>.Run(   )

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskResult
{
    class Program
    {
        static int CalcSize(string data)  //대상 메서드
        {
            string s = data == null ? "" : data.ToString();
            Thread.Sleep(1000); // 복잡한 계산 가정
            return s.Length;
        }

        static void Main(string[] args)
        {
            // Task<T>를 이용하여 쓰레드 생성과 시작
            Task<int> task = Task.Factory.StartNew<int>( () => CalcSize("Hello World") );

            //var task = Task<int>.Run( () => CalcSize("hello world") );

            // 메인 쓰레드에서 다른 작업 실행

            // 쓰레드 결과 리턴. 쓰레드가 계속 실행중이면 이곳에서 끝날 때까지 대기함
            int result = task.Result;           // .Result

            Console.WriteLine("Result = {0}", result);
        }

    }

}

/*
// 1부터  100000만 더하기 예제                  //Task.Factory.StartNew()

    static long Sum(int fr, int to)
    {
        long total = 0;
        for (int i = fr; i <= to; i++)
            total += i;
        return total;
    }

    static void Main(string[] args)
    {            
        Task<long> task = Task.Factory.StartNew<long>(() => Sum(1,50000));
        long sum = Sum(50001, 100000);
        long result = task.Result;
        Console.WriteLine("Result = {0}", sum + result);
    }

// 위 문제를 스레드 4개로 처리해보세요.



/*
// Task.Run() 과 Task.Factory.StartNew()의 차이점 *** 

.NET Framework 4.5 Developer Preview에는 새로운 Task.Run 메서드가 도입되었습니다. 
    이것은 결코 Task.Factory.StartNew를 폐기하는 것이 아니라, 
    단지 많은 매개 변수를 지정할 필요없이
    Task.Factory.StartNew 를 사용하는 빠른 방법으로 생각해야 합니다.

예컨데 
    Task.Run(someAction);

이것은 정확히 다음과 같습니다.
    Task.Factory.StartNew(someAction,
        CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);

*/

//Task 작업 취소
//
//   비동기 작업을 취소하기 위해서는 Cancellation Token을 사용하는데,
//   작업 취소와 관련된 타입은 CancellationTokenSource 클래스와 CancellationToken 구조체이다.
