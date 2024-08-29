/*
await 키워드는 연속 콜백의 부착을 단순화한다. 간단한 예로, 컴파일러는 다음과 같은 코드를

    var 결과 = await 표현식;
    문장(들);

기능상으로 다음에 해당하는 코드로 바꾸어서 컴파일한다.

    var awaiter = 표현식.GetAwaiter();
    awaiter.OnCompleted(() => {
	    var 결과 = awaiter.GetResult();
	    문장(들);
    });
*/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace MyCSharp // 프로젝트 이름
{
    public class MyClass
    {
        Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() =>
                ParallelEnumerable.Range(start, count).Count(n =>
                    Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0))); //소수
        }

        public async void DisplayPrimesCount()
        {
            int result = await GetPrimesCountAsync(2, 1000);            //await

            Console.WriteLine(result);
        }

        public void DisplayPrimesCount2()
        {
            //GetAwaiter
            var awaiter = GetPrimesCountAsync(2, 1000).GetAwaiter();             
            awaiter.OnCompleted(() => {
                int result = awaiter.GetResult();
                Console.WriteLine(result);
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.DisplayPrimesCount();

            Console.ReadLine();  //wait
        }
    }
}


/*

//Task를 돌려주는 비동기 함수  -----------------------------------------------

// 반환 형식이 void인 메서드가 있을 때, 
//      void를 Task로 바꾸고 async를 적용하면, 
//      메서드 자체가 await를 적용할 수 있는 유용한 비동기 버전으로 변한다. 

    async Task PrintAnswerToLife() {  // void 대신 Task를 돌려준다.
	    await Task.Delay(5000);
	    int answer = 21 * 2;
	    Debug.Log(answer);
    }

    //덕분에 비동기 호출 연쇄(비동기 함수 안에서 다른 비동기 함수를 호출하는)를 사용하기가 어렵지 않다.
    async Task Go() {
	    await PrintAnswerToLife();
	    Debug.Log("Done");
    }

// 반환 형식이 void가 아닌 메서드를 비동기화할 때,
//      Task<T> 형식으로 async를 적용

    async Task<int> GetAnswerToLife() {
	    await Task.Delay(5000);
	    int answer = 21 * 2;
	    return answer;
    }
    async Task PrintAnswerToLife() {
	    int answer = await GetAnswerToLife();
	    Debug.Log(answer);
    }
    async Task Go() {
	    await PrintAnswerToLife();
	    Debug.Log("Done");
    }


//비동기 람다 표현식- --------------------------------------------------------

    // 통상적인 메서드 ------------------------
    async Task NamedMethod() { await Task.Delay(1000); }

    await NamedMethod();    //호출,대기

    //이름이 없는 메서드 ----------------------
    Func<Task> unnamed = async () => { await Task.Delay(1000); };

    await unnamed();        //호출,대기


    //비동기 람다식을 이벤트 처리부로 등록하는 예이다.
    myButton.Click += async(sender, args) => {
	    await Task.Delay(1000);
	    myButton.Content = "Done";
    };

    //비동기 람다식 역시 Task를 돌려줄 수 있다.

    Func<Task<int>> unnamed = async () => {
	    await Task.Delay(1000);
	    return 123;
    };
    int answer = await unnamed(); //호출,대기,결과
 

// 동기적 완료 -------------------------------------------------------------------------

// 동기 함수가 대기 이전에 반환될 수도 있다. 
//    웹 페이지를 내려받는 연산에 캐싱을 적용하는 다음과 같은 메서드를 생각해 보자.
//    이 메서드는 주어진 URI가 캐시에 존재하면 대기를 수행하지 않고 즉시 결과를 반환한다. 
//    이때 결과는 이미 신호된 작업 객체이다. 이러한 방식을 동기적 완료라고 부른다.

    static Dictionary<string, string> _cache = new Dictionary<string, string>();

    async Task<string> GetWebPageAsync(string uri) {
	    string html;
	    if (_cache.TryGetValue(uri, out html)) return html;                         // 동기적 완료
	    return _cache[uri] = await new WebClient().DownloadStringTaskAsync(uri);    //
    }

*/
