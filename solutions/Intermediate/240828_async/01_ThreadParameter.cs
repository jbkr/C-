// 파라미터 전달

using System;
using System.Collections;
using System.Collections.Concurrent; // ConcurrentBag
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBasic       //파라미터 전달
{
    class Program
    {
        static void Run()                       // void(void)
        {
            Console.WriteLine("Run");
        }
        
        static void Calc(object radius)         // 파라미터를 object 타입으로
        {
            double r = (double)radius;
            Console.WriteLine("r = {0}, area = {1}", r, r * r * 3.14);
        }

        static void Sum(int d1, int d2, int d3) // 파라미터 여러개인 경우
        {
            int sum = d1 + d2 + d3;
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            // 파라미터 없는 경우   - ThreadStart 사용
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // ParameterizedThreadStart     - Start()의 파라미터로 radius 전달
            Thread t2 = new Thread(new ParameterizedThreadStart(Calc));
            t2.Start(10.00);

            // ThreadStart 로 래핑헤서 파라미터 전달하기     - 메서드 직접 전달
            Thread t3 = new Thread(() => Sum(10, 20, 30));  
            t3.Start();
        }
        
    }   
}

/*

//Background 와 Foreground 쓰레드의 기본적인 차이점은 
//  Foreground 쓰레드는 
//  메인 쓰레드가 종료되더라도 Foreground 쓰레드가 살아 있는 한, 프로세스가 종료되지 않고 계속 실행되고, 
//  Background 쓰레드는 
//  메인 쓰레드가 종료되면 바로 프로세스를 종료한다는 점이다.

    // Foreground 쓰레드
    Thread t1 = new Thread(new ThreadStart(Run));
    t1.Start();

    // Background 쓰레드
    Thread t2 = new Thread(new ThreadStart(Run));
    t2.IsBackground = true;         // Start()를 실행하기 전에 IsBackground 속성을 true/false로 지정
    t2.Start();

*/