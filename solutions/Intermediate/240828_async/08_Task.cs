using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UsingTask
{
    class MainApp
    {
        static void Func()                           //비동기 처리할 메서드
        {
            Console.WriteLine("Long running method");
        }

        static void Main(string[] args)
        {            
            Task t1 = new Task(new Action(Func));    // Task 생성자에 Run을 지정 Task 객체 생성
            // Task 쓰레드 시작
            t1.Start();
            // Task가 끝날 때까지 대기
            t1.Wait();

            Task t2 = new Task(() => {              // 람다식을 이용 Task객체 생성
                Console.WriteLine("Long query");
            });
            t2.Start();
            t2.Wait();

            // Task.Run 으로 바로 시작 -----------------------------------------

            Task t3 = Task.Run(() => {          
                Console.WriteLine("Long query");    
            });
            t3.Wait();

            // Task<T>.Run 으로 result 획득 가능 //T 는 리턴타입 ---------------

            Task<int> t4 = Task<int>.Run(() => {
                return 7;
            });
            t4.Wait();
            int rt = t4.Result;


            var myTask = Task<List<int>>.Run( () =>
            {
                    Thread.Sleep(1000);

                    List<int> list = new List<int>();
                    list.Add(3);
                    list.Add(4);
                    list.Add(5);

                    return list;
                }
            );
            myTask.Wait();

            List<int> list = myTask.Result;     //myTask.Result
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //Task.Factory.StartNew() --------------------------
            //쓰레드를 생성과 동시에 시작

            Task.Factory.StartNew(Func);         
        }
    }
}

/*

    static void Main(string[] args)
    {
        string srcFile = args[0];

        Action<object> FileCopyAction = (object state) =>
        {
            String[] paths = (String[])state;
            File.Copy(paths[0], paths[1]);

            Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId,
                paths[0], paths[1]);
        };

        Task t1 = new Task(
            FileCopyAction, new string[]{srcFile, srcFile+".copy1"});

        t1.Start();

        Task t2 = Task.Run(() => { 
            FileCopyAction(new string[] { srcFile, srcFile + ".copy2" }); 
        });

        Task t3 = new Task(
            FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

        t3.RunSynchronously();

        t1.Wait();
        t2.Wait();
        t3.Wait();

    }
*/