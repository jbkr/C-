//Task<T>.Factory.StartNew 예제

//async Method()
//{
//      Task<T> task = Task<T>.Factory.StartNew( ()=>{return T;} );
//      await task;
//}


using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MyCSharp // 프로젝트 이름
{
    class Program
    {
        class AsyncTest
        {
            double Calc(double r)               // 이 함수를 비동기로 불러보자.
            {                
                Thread.Sleep(3000); // 3초간 긴 계산
                return 3.14 * r * r;
            }

            public async void Call()            //async         //비동기함수
            {
                Task<double> task = Task<double>.Factory.StartNew( () => Calc(10) );
                await task;                     //await task    //비동기로 실행
                Console.WriteLine("call end");  //task.Result
            }
        }

        static void Main(string[] args)
        {
            AsyncTest x = new AsyncTest();
            Console.WriteLine("start");
            x.Call();
            Console.WriteLine("end");
            Console.ReadLine(); // 프로그램 종료 방지
        }
    }
}

//await는
//      UI 쓰레드가 정지되지 않고 메시지 루프를 계속 돌 수 있도록 필요한 코드를 컴파일러가 자동으로 추가
//await는 해당 Task가 끝날 때까지 기다렸다가 완료 후, 바로 다음 실행문부터 실행을 계속하는데,
//      이 때의 쓰레드는 디폴트로 await를 호출하기 이전의 실행 쓰레드가 된다. 
//      즉 UI Thread에서 await를 호출하였다면 await 다음 문장들은 UI 쓰레드에서 실행된다.
//
//Note: 만약 task.ConfigureAwait(false)를 실행하면 쓰레드풀의 쓰레드로 실행된다
