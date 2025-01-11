//분할 연산자    Partition Operator
//      LINQ 에서 제공하는 확장 메서드 중
//      Take, Skip, TakeWhile, SkipWhile 을 분할 연산자라 합니다.
//      분할 연산자는 출력 시퀀스를 분할시켜 반환.

using System;
using System.Collections.Generic;
using System.Linq;


class MainApp
{
    static List<Customer> GetCustomerList()
    {
        List<Customer> list = new List<Customer>() {
                new Customer{CustomerID = "a" , Region = "WA" },
                new Customer{CustomerID = "b" , Region = "LA" }
            };
        return list;
    }
    static void Main(string[] args)
    {
        //Take 분할 연산자 -------------------------------------------------------------
        //Take 메서드로 numbers 배열에서 처음 3개의 원소만 꺼내 출력 시퀀스를 만듭니다.

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var first3Numbers = numbers.Take(3);
        // first3Numbers = { 5, 4, 1 };

        //출력 시퀀스는 IEnumerable 인터페이스로 반환되므로
        //LINQ 결과에 Take 메서드를 연결하여 사용할 수 있습니다. ***

        List<Customer> customers = GetCustomerList();
        var first3WAOrders = (
            from cust in customers
            from order in cust.Orders
            where cust.Region == "WA"
            select (cust.CustomerID, order.OrderID, order.OrderDate))
            .Take(3);


        //Skip 분할 연산자 -------------------------------------------------------------
        //Skip 메서드로 numbers 배열에서 처음 4개의 원소를 건너뛰고 출력 시퀀스를 만듭니다.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var allButFirst4Numbers = numbers.Skip(4);
        // allButFirst4Numbers = { 9, 8, 6, 7, 2, 0 }

        //Take 메서드와 마찬가지로, Skip 메서드도 Ienumerable 인터페이스에 정의되어 있어서 LINQ 결과에 연결하여 사용할 수 있습니다.

        List<Customer> customers1 = GetCustomerList();
        var waOrders = from cust in customers1
                       from order in cust.Orders
                       where cust.Region == "WA"
                       select (cust.CustomerID, order.OrderID, order.OrderDate);
        var allButFirst2Orders = waOrders.Skip(2);


        //TakeWhile 분할 연산자 -------------------------------------------------------------

        //TakeWhile 와 SkipWhile 은 Take 와 Skip과 달리,
        //주어진 조건에 도달하기 전까지만 출력 시퀀스에 포함합니다.

        //TakeWhile 메서드로 numbers 배열 원소 중 6 보다 작은 원소가 나오는 것만 출력 시퀀스에 포함합니다.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
        // firstNumbersLessThan6 = { 5, 4, 1, 3 }

        //numbers 배열 중 원소의 index 값보다 큰 원소가 나오기 전만 출력 시퀀스에 포함합니다.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
        // firstSmallNumbers = { 5, 4 }


        //SkipWhile 분할 연산자 -------------------------------------------------------------

        //numbers 배열 첫 원소부터 시작해서 3 으로 나누어 떨어지 않는 원소를 건너뛰고,
        //3 으로 나누어 떨어지는 원소부터 출력 시퀀스를 만듭니다.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);
        // allButfirst3Numbers = { 3, 9, 8, 6, 7, 2, 0 };

        // numbers 배열 첫 원소부터 시작해서 index 값보다 같거나 큰 원소는 건너뛰고,
        // index 값보다 작은 원소부터 출력 시퀀스를 만듭니다.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
        // laterNumbers = { 1, 3, 9, 8, 6, 7, 2, 0 }






        /// <summary>
        /// 
        /// </summary>

        //속성으로 필터링하기
        List<Customer> customers2 = GetCustomerList();
        var waCustomers = from cust in customers2
                          where cust.Region == "WA"
                          select cust;


        //서로 연관있는 입력 시퀀스로부터 하나의 출력 시퀀스 만들기
        //customers 리스트와 customers의 속성인 Orders를 입력 시퀀스로 받아, 
        //500 이하인 order 만 모은 출력 시퀀스를 만듭니다.

        List<Customer> customers3 = GetCustomerList();

        var orders1 = from c in customers3
                      from o in c.Orders
                      where o.Total < 500.00M
                      select (c.CustomerID, o.OrderID, o.Total);


        //1998.01.01 이후 주문만 모은 출력 시퀀스를 만듭니다.

        List<Customer> customers4 = GetCustomerList();

        var orders2 = from c in customers4
                      from o in c.Orders
                      where o.OrderDate >= new DateTime(1998, 1, 1)
                      select (c.CustomerID, o.OrderID, o.OrderDate);


        //여러 Where 절을 활용해 입력 시퀀스를 제한한 특정한 출력 시퀀스를 만들 수도 있습니다.
        //아래 예제는 고객 중 WA 지역에 살면서 1997.01.01 d이후 주문만 출력하는 시퀀스를 만듭니다.

        List<Customer> customers5 = GetCustomerList();
        DateTime cutoffDate = new DateTime(1997, 1, 1);
        var orders3 = from c in customers5
                      where c.Region == "WA"
                      from o in c.Orders
                      where o.OrderDate >= cutoffDate
                      select (c.CustomerID, o.OrderID);


        //SelectMany 절     
        //  SelectMany - SQL의 Cross Join과 같이 가능한 모든 조인 집합
        //  아래 예제는 처음 LINQ 를 사용하는 초보자에게 이해하기 어렵습니다. 
        //  '이런 사용 방법도 있구나'하고 넘어가시면 되겠습니다.

        List<Customer> customers6 = GetCustomerList();

        var customerOrders =
            customers6.SelectMany(
                (cust, custIndex) =>
                cust.Orders.Select(o =>
                    "Customer #" + (custIndex + 1) + " has an order with OrderID " + o.OrderID
            ));
    }
}


public class Customer
{
    public string CustomerID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Region { get; set; }
    public List<Order> Orders { get { return Orders; } }
}
public class Order
{
    public string OrderID { get; set; }
    public string OrderDate { get; set; }
    public string CustomerID { get; set; }
    public List<OrderItem> Items { get { return Items; } }
}
public class OrderItem
{
    public string ItemID { get; set; }
    public int Quantity { get; set; }
}







