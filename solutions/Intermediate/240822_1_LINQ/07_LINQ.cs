//LINQ의 구현 원리를 이해 하려면 
//    => 확장 메소드(extension method) 문법
//    => Delegate(Func)와 람다 표현식
//    => Coroutine 개념 참조

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyCSharp // LINQ 활용 
{
    class Program
    {
        // 처음 요소가 주어진 이름과 같은 경우, 나머지 데이타를 출력하세요. //단, null 이면 0으로 대신 출력
        // "a" 입력하면  10 0 30 출력
        // "b" 입력하면  20 40 30 출력
        static List<string> F1(string name)
        {
            var sheet = new[] {
                new List<string>() { "a", "10", null, "30" },
                new List<string>() { "b", "20", "40", "30" },
                new List<string>() { "a", "40", "60", "70" },
                new List<string>() { "c", "30", "50", "60" },
            };

            //foreach (var row in sheet)
            //{
            //    if (row[0] == name)
            //    {
            //        var points = row.Skip(1);
            //        var pointList = new List<string>();
            //        foreach (var point in points)
            //        {
            //            pointList.Add(point);
            //        }
            //        return pointList;
            //    }
            //}

            var result = sheet
                .Where(x => x[0] == name)
                .FirstOrDefault()       //null or Default
                .Skip(1)                //첫변째 스킵
                .Select(x => x ?? "0")  //null 이면 0
                .ToList();
            return result;
        }

        static void Main(string[] args)
        {
            var list = F1("a");
            if (list != null) list.ForEach(x => Console.WriteLine(x));


            //Console.ReadLine();
        }
    }

    public static class LINQExtension
    {
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
                action(item);
        }
    }
}

//// LINQ 활용 


////첫번째는 가독성. LINQ는 “깊은 코드”를 막아준다 ----------------------------------------------

//    var sheet = GetSheet();

//    foreach (var row in sheet)
//    {
//        if ((row[0] as string) == name)
//        {
//            var points = row.Skip(1);
//            var pointList = new List<string>();
//            foreach (var point in points)
//            {
//                pointList.Add(int.Parse((point as string) ?? "0"));
//            }
//            return (pointList[0], pointList[1]);
//        }
//    }

//    var result = sheet
//        .Where(x => (x[0] as string) == name)
//        .FirstOrDefault()
//        .Skip(1)
//        .Select(x => int.Parse((x as string) ?? "0"))
//        .ToArray();
//    return (result[0], result[1]);


////두번째 이유는 확장 메서드 -------------------------------------------------------------------

//    public static class LINQExtension
//    {
//        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
//        {
//            foreach (var item in list)
//                action(item);
//        }
//    }

//    // SQL문법과 비슷한 C# 문법을 제공한다는 점에서 많은 편리함을 제공하지만, 
//    // 실제 .NET CLR 에서는 이러한 쿼리들이 메서드 형태로 호출되어야 하므로, 
//    // 이러한 쿼리들은 C# 컴파일시에
//    // 내부적으로 확장메서드(Extension Method)로 변경되어진다.

//    // 쿼리식 표현
//    var v = from ord in db.Orders
//            where ord.Customer_ID == "FRANS"
//            orderby ord.Order_Date ascending
//            select ord;

//    // 메서드식 표현1
//    var v = db.Orders.Where(order => order.Customer_ID == "FRANS").Select(o => o);

//    // 메서드식 표현2
//    // 위의 메서드식 표현1의 Select()메서드는 동일데이타를 변형없이 리턴하므로 생략가능
//    var v = db.Orders.Where(order => order.Customer_ID == "FRANS");


////Lazy Evaluation ---------------------------------------------------------------------------

//    //  Lazy Evaluation이란 컬렉션의 정의만을 설정해두고 내부의 값을 정의는 해당 값이 호출될 때까지 미루는 것
//    //  이러한 Lazy Evaluation을 통해서 불필요한 컬렉션의 호출과 연산을 생략할 수 있다.

//    var list = new int[] { 10, 20, 30, 40, 45, 50 };
//    var result = list
//        .Where(x => {
//            Console.WriteLine($"[Where] {x}");
//            return x > 30;
//        })
//        .Select(x => {
//            Console.WriteLine($"[Select] {x}");
//            return x * x;
//        });

//    Console.WriteLine(string.Join(",", result));  //출력전에는 연산 안함.

