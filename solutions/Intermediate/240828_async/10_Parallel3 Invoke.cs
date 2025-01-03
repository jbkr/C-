//Task Parallel Library (TPL)
//
//      Task 관련 클래스들과 Parallel 클래스들을 합쳐
//      Task Parallel Library(TPL)이라 부르는데,
//      이들은 기본적으로 다중 CPU 병렬 처리를 염두에 두고 만들었다.

//Task 클래스 

//Parallel.Invoke()
//    Parallel.Invoke() 메서드는 여러 작업들을 병렬로 처리하는 기능을 제공한다. 
//    즉, 다수의 작업 내용을 Action delegate로 받아 들여
//    다중 쓰레드들로 동시에 병렬로 Task를 나눠서 실행하게 된다.

using System;    
using System.Threading.Tasks;    

class Program
{
    static void Main(string[] args)
    {
        // 5개의 다른 Task들을 병렬로 실행
        Parallel.Invoke(
            () => { Run(); },
            () => { Run(); },
            () => { Run(); },
            () => { Run(); },
            () => { Run(); }
        );
    }
    static void Run()
    {
        Console.WriteLine("Long running method");
    }
} 

