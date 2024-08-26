//LINQ의 메서드식 표현
//    => 확장 메소드(extension method) 문법
//    => Delegate(Func)와 람다 표현식

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// LINQ 활용 

class Order     //주문
{
    public string Customer_ID { get; set; }
    public int Order_ID { get; set; }
    public DateTime Order_Date { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var Orders = new Order[] {
            new Order { Customer_ID = "FRANS", Order_ID = 1000 },
            new Order { Customer_ID = "FRANS", Order_ID = 1001 },
            new Order { Customer_ID = "JAMES", Order_ID = 1002 },
            new Order { Customer_ID = "JAMES", Order_ID = 1003 },
            new Order { Customer_ID = "FRANS", Order_ID = 1004 },
        };

        // 메서드식 표현
        var v1 = Orders.Where(order => order.Customer_ID == "FRANS").Select(o => o);

        // 위의 메서드식 표현1의 Select()메서드는 동일데이타를 변형없이 리턴하므로 생략가능
        var v2 = Orders.Where(order => order.Customer_ID == "FRANS");


        //LINQ to SQL : Select() 메서드 --------------------------------------------------------------------
        //
        //  Select() 메서드는
        //  데이타를 변형하거나 부분 선택하여 새로운 클래스(Anonymous Type)를 만들어 리턴하고 싶은 때 사용한다. 
        //  아래 예제는 전체 Order레코드 중 일부 필드들을 선별 변형하여 새로운 익명 타입을 만든 예이다.

        //예제 // Select() 메서드를 이용해 Anonymous Type을 새로 정의

        var v6 = Orders.Where(o => o.Customer_ID == "FRANS")
                .Select(p => new { Id = p.Order_ID, Date = p.Order_Date });
        foreach (var o in v6)
        {
            //listBox1.Items.Add(o.Id + ":" + o.Date);
        }


        //LINQ to SQL : 단일 레코드 리턴 --------------------------------------------------------------------
        //  
        //  LINQ에서 사용되는 많은 Extension Method들 중 단일 레코드를 리턴하는 메서드가 있다. 
        //  Single() 혹은 SingleOrDefault()라는 메서드인데, 이는 데이타가 하나라는 전제하에 사용된다. 
        //  만약 여러 Row를 리턴하면 에러가 발생한다. 
        //  Single()은 데이타가 반드시 1개 존재하며, 그럴지 않을 경우 Exception을 발생시킬 때 쓰는 메서드이고, 
        //  SingleOrDefault()는 데이타가 1개 일때는 해당 데이타를 데이타가 
        //  없을 경우는 해당 Type의 디폴트 값 (일반적으로 NULL)을 리턴할 때 사용된다. 
        //  일반적으로 SingleOrDefault()를 사용하여 NULL을 체크하는 방식을 자주 사용한다.

        //예제
        var v3 = Orders.Where(o => o.Order_ID == 10001).SingleOrDefault();
        if (v3 != null)
        {
            //txtDate.Text = v.Order_Date.ToString();
        }


        //LINQ to SQL : 처음 레코드 리턴 --------------------------------------------------------------------
        //
        //  만약 조건식에 맞는 처음 레코드를 찾는 경우,
        //  First() 혹은 FirstOrDefault()라는 메서드를 사용한다. 
        //  이는 데이타가 여러 개 리턴될 경우도 사용할 수 있으며, 그 중 처음 레코드만을 리턴한다.

        var v4 = Orders.Where(o => o.Customer_ID == "FRANS").FirstOrDefault();

        // FirstOrDefault 의 리턴이 null 이 아닌 경우 처리

        var items = new Dictionary<int, string>() { { 1, "Item1" }, { 2, "Item2" }, { 3, "Item3" } };
        var item = items.FirstOrDefault(p => p.Value.StartsWith("J"));
        if (item.Equals(default(KeyValuePair<int, string>)))
            throw new Exception("No Item Found");


        //LINQ to SQL : OrderBy ---------------------------------------------------------------------------
        //
        //  데이타를 올림차순 내림차순으로 정의하기 위해서는 OrderBy() 메서드를 사용한다. 
        //  OrderBy()는 기본적으로 올림차순으로 정렬하며, 만약 내림차순이나 다른 비교 연산을 사용하려면, 
        //  IComparer를 구현하는 클래스를 만들어 파라미터로 지정한다.

        //예제 // 주문날짜 올림차순으로 정렬
        var v5 = Orders.Where(o => o.Customer_ID == "FRANS").OrderBy(p => p.Order_Date);
        foreach (var o in v5)
        {
            //listBox1.Items.Add(o.Order_ID);
        }
        /*
            //예제 // IComparer를 구현하는 클래스
            public class CaseInsensitiveComparer : IComparer<string>
            {
                public int Compare(string x, string y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }

            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
        */

    }
}

