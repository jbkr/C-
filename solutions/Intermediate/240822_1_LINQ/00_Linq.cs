// LINQ
//      대량의 데이타를 데이타베이스 처럼 '쿼리 문법'을 이용해서 쉽게 처리.

// LINQ 를 이해하기 위해는
//      제네릭(Generic), 확장 메서드(Extension Methods), 익명 타입(Anonymous Methods) 도 함께 공부

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Linq
{
    static void Main(string[] args)
    {
        // 입력과 출력을 나타내는 리스트를 생성합니다.
        List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 짝수만 목록 만들기 ------------------------------------------------------
        // generic collection
        List<int> output = new List<int>();
        foreach (var item in input)
        {
            if (item % 2 == 0)
                output.Add(item);
        }

        // linq 로 바꾸면 --------------------
        var output2 = from item in input
                      where item % 2 == 0
                      select item;

        // orderby ------------------------------------------------------------ // 순서

        int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };  // 짝수만 골라 출력하세요 

        var result = from n in numbers
                     where n % 2 == 0
                     orderby n      // 순서대로 정렬하기 
                     select n;      // select 하면 IEnumerable 타입으로 리턴

        foreach (int n in result)
            Console.WriteLine($"짝수 : {n}");


        // 연습 -------------------------------------------------------------------
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 3보다 큰 홀수 목록  // 5 7 9
        var output3 = from a in arr
                      where a > 3 && a % 2 == 1
                      select a;

        // 2배가 되는 수 목록  // 2 4 6 8 ... 20
        var output4 = from item in arr select item * 2;

        // 제곱 수 목록  //1 4 9 16 ... 100
        var output5 = from item in arr select item * item;


        // 글자수 목록을 출력하세요. -----------------------------------------------
        List<string> input2 = new List<string>() { "apple", "banana", "melon" };

        //Collection    // 5 6 5
        List<int> out2 = new List<int>();
        foreach (var item in input2) out2.Add(item.Length);
        foreach (var item in out2) Console.WriteLine(item);

        //Linq  // 5 6 5
        var output6 = from s in input2 select s.Length;
        foreach (var item in output6) Console.WriteLine(item);


        // Linq 로 표현하세요. ---------------------------------------------------
        {
            List<int> input3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> out3 = new List<int>();
            foreach (var item in input3)
            {
                if (item % 4 == 1) out3.Add(item);
            }
            out3.Sort();

            var out1 = from item in input3
                       where item % 4 == 1
                       orderby item ascending
                       select item;
        }

    }

    // 링큐의 반환 형식 IEnumerable<T>
    //      
    //      ToArray(), ToList() 로 변환하여 사용 가능

    static IEnumerable<int> GeneralSearchWithLinq()
    {
        List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        return from item in input
               where item % 2 == 0
               select item;
    }

}


/*

// 익명 타입 ---------------------------------------------

    //class NameCard
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    //NameCard c = new NameCard() { Name = "아무개", Age = 19 };

    // 익명 타입 : new { 속성1 = 값, 속성2 = 값; }
    //var nc = new { Name = "홍길동", Age = 20 };
    //string s = nc.Name; 
*/
