//Task 관련 클래스들과 Parallel 클래스들을 합쳐
//Task Parallel Library(TPL)이라 부르는데,
//이들은 기본적으로 다중 CPU 병렬 처리를 염두에 두고 만들었다.

//Task 클래스 ---------------------------------------------------

using System;    
using System.Threading.Tasks;    

class Program
{
    static void Main(string[] args)
    {
        // Task 생성자에 Run을 지정 Task 객체 생성
        Task t1 = new Task(new Action(Run));

        // 람다식을 이용 Task객체 생성
        Task t2 = new Task(() => { Console.WriteLine("Long query");});

        // Task 쓰레드 시작
        t1.Start();
        t2.Start();

        // Task가 끝날 때까지 대기
        t1.Wait();
        t2.Wait();            
    }

    static void Run()
    {            
        Console.WriteLine("Long running method");
    }
} 

//Task.Factory.StartNew -----------------------------------------------
//      Task.Factory 를 이용하여 쓰레드 생성과 시작

using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {        
        Task.Factory.StartNew(new Action<object>(Run), null);   //매개변수
        Task.Factory.StartNew(new Action<object>(Run), "1st");
        Task.Factory.StartNew(Run, "2nd");

        Console.Read();
    }

    static void Run(object data)
    {
        Console.WriteLine(data == null ? "NULL" : data);
    }
}


//Task.FromResult -------------------------------------------------------

public async Task DoWork()
{
    int res = await Task.FromResult<int>(GetSum(4, 5));
}

int GetSum(int a, int b)
{
    return a + b;
}
