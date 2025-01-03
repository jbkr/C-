/*
class Program
{
    static void DoSomething()
    {
        Console.WriteLine("Thread Func");
    }

    static void Main(string[] args)
    {
        Thread t = new Thread(DoSomething);
        t.Start();
        //
        t.Join();
    }
}
*/

using System;
using System.Threading;

class Program
{
    static void DoSomething()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"DoSomething : {i}");
            Thread.Sleep(10);
        }
    }

    static void Main(string[] args)
    {            
        Thread t1 = new Thread(new ThreadStart(DoSomething));       //Thread - ThreadStart

        //Console.WriteLine("Starting thread...");
        t1.Start();                                                 //Start

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main : {i}");
            Thread.Sleep(10);
        }
            
        //Console.WriteLine("Wating until thread stops...");
        t1.Join();                                                  //Join

        Console.WriteLine("Finished");
    }
}


//ParameterizedThreadStart --------------------------------------------------

class Program
{
    static void Main(string[] args)
    {
        Thread thd = new Thread(new ParameterizedThreadStart(ThreadProc));  
        Console.WriteLine("스레드 실행");
        
        thd.Start("파라미터를 지정");      //object형 하나의 매개변수만 지정 가능.
           
        thd.Join(); // 메인 스레드는 대기.

        Console.WriteLine("스레드 종료, 메인 스레드 종료.");
    }

    public static void ThreadProc(object obj)
    {
        Console.WriteLine("메서드 실행 => obj:" +(string)obj);
    }
}

// 파라미터가 object형으로 전달되기 때문에 해당 프로시저에서 문제가 발생할 소지가 농후하다.
// 따라서 ThreadStart 대리자, 파라미터와 스레드 프로시저를 랩핑한 클래스를 구현하는 것이 바람직하다.


// ThreadId 출력하기
//      Console.WriteLine("Main " + Thread.CurrentThread.ManagedThreadId);