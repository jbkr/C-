//비동기 처리예제, 웹 페이지 접속
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

using static System.Console;

namespace MyCSharp // 프로젝트 이름
{
    public class MyClass
    {
        // Mark the event handler with async so you can use await in it.  
        public async void OnClick()
        {
            // Call and await separately.
            //Task<int> getLengthTask = AccessTheWebAsync();              
            //int contentLength = await getLengthTask;  

            int contentLength = await AccessTheWebAsync();
            Console.WriteLine($"\r\nLength of the downloaded string: {contentLength}.\r\n");
        }

        // Three things to note in the signature:  
        //  - The method has an async modifier.   
        //  - The return type is Task or Task<T>. (See "Return Types" section.)  
        //    Here, it is Task<int> because the return statement returns an integer.  
        //  - The method name ends in "Async."  
        async Task<int> AccessTheWebAsync()
        {
            // You need to add a reference to System.Net.Http to declare client.  
            using (HttpClient client = new HttpClient())
            {
                // GetStringAsync returns a Task<string>. That means that when you await the  
                // task you'll get a string (urlContents).  
                Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com");

                // You can do work here that doesn't rely on the string from GetStringAsync.  
                DoIndependentWork();

                // The await operator suspends AccessTheWebAsync.  
                //  - AccessTheWebAsync can't continue until getStringTask is complete.  
                //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
                //  - Control resumes here when getStringTask is complete.   
                //  - The await operator then retrieves the string result from getStringTask.  
                string urlContents = await getStringTask;

                // The return statement specifies an integer result.  
                // Any methods that are awaiting AccessTheWebAsync retrieve the length value.  
                return urlContents.Length;
            }
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working . . . . . . .\r\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            mc.OnClick();

            Console.ReadLine();
        }
    }
}
