using System;
using System.Threading;

/*
    class Counter
    {
        const int LOOP_COUNT = 1000;
        private int count;              // 보호하려는 자원
        public int Count 
        { 
            get { return count; } 
        }

        public Counter()
        {
            count = 0;
        }

        public void Increment()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0) {
                count++;                //count
            }
        }

        public void Decrement()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0) {
                count--;                //count
            }
        }
    }
 */
namespace Synchronize
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        private int count;              // 보호하려는 자원 //공유 자원
        public int Count 
        { 
            get { return count; } 
        }

        readonly object thisLock;       // 크리티컬 섹션 객체 

        public Counter()
        {
            thisLock = new object();    // 크리티컬 섹션 객체 생성
            count = 0;
        }

        public void Increment()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock) { count++; }    //lock
                Thread.Sleep(1);
            }
        }

        public void Decrement()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock) { count--; }    //lock
                Thread.Sleep(1);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread( new ThreadStart(counter.Increment) );
            Thread decThread = new Thread( new ThreadStart(counter.Decrement) );

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
