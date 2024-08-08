using System;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[3];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
        }
    }
}

