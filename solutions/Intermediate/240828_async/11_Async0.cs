//async 메서드 - await 사용하기

using System;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        public static async Task Main(string[] args)   
        {
            //Task --------------------------------------------------

            Task t = TaskTest();

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Do Something Before TaskTest 1");

            await t;

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Do Something after TaskTest 2");

            Console.ReadLine();

            //Task<T> ----------------------------------------------

            Task<int> t2 = TaskTest2();

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Do Something Before TaskTest");

            int UID = await t2;
            Console.WriteLine($"UserID : {UID}");

            Console.ReadLine();
        }

        private static async Task TaskTest()                    //async Task
        {
            await Task.Delay(5000); // 오래 걸리는 작업
            Console.WriteLine("TaskTest Done");
        }
        private static async Task<int> TaskTest2()              //async Task<int>
        {
            await Task.Delay(5000); // 오래 걸리는 작업
            Console.WriteLine("TaskTest Done");
            int UID = 100;
            return UID;                                         //결과 리턴
        }

    }
}