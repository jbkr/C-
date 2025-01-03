//select   

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        // Select where 절
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNums = from num in numbers
                          where num < 5
                          select num;
            // { 4, 1, 3, 2, 0 };


            // index 사용 가능 ***
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            // { "five", "six", "seven", "eight", "nine" };


            //속성으로 필터링하기
            List<Product> products = GetProductList();
            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;
        }

        // Select 절
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsPlusOne = from n in numbers
                              select n + 1;
            // { 6, 5, 2, 4, 10, 9, 7, 8, 3, 1 };


            //하나의 속성만 선택하기
            //products 객체로 이루어진 입력 시퀀스에서 ProductName 속성으로 출력 시퀀스를 만듭니다.
            List<Product> products = GetProductList();
            var productNames = from p in products
                               select p.ProductName;

            //다른 타입으로 출력 바꾸기 **
            //numbers 배열을 활용해 문자로 표현된 숫자 출력 시퀀스를 만듭니다.

            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var textNums = from n in numbers
                           select strings[n];
            // { "five", "four", "one", "three", "nine", "eight", "six", "seven", "two", "zero" };
        }

        //출력에 익명 형식 활용하기 **        
        {
            //입력 시퀀스를 Select 절에서
            //new 생성자를 활용해 Upper 속성과 Lower 속성을 가진 익명 형식의 출력 시퀀스를 생성합니다.

            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperLowerWords = from w in words
                                  select new { Upper = w.ToUpper(), Lower = w.ToLower() };
            //{ { APPLE, apple },{ BLUEBERRY, blueberry },{ CHERRY, cherry },}

            //새로운 타입 생성하기
            //익명 형식을 활용하여 새로운 타입으로 출력을 투영합니다.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitOddEvens2 = from n in numbers
                                 select new { Digit = strings[n], Even = (n % 2 == 0) };
            // {
            // { Digit = "five", Even = false },
            // { Digit = "four", Even = true },
            // { Digit = "one", Even = false },
            // ...
            // }

        }

        //튜플 형식 **
        //익명 형식을 활용하면 불필요한 클래스 생성을 줄일 수 있습니다. 
        //C# 7.0 버전부터 Tuple 로도 출력을 투영할 수 있습니다.
        //출력은 System.ValueTuple 형식을 가진 System.Collections.IEnumerable 시퀀스가 됩니다.
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitOddEvens = from n in numbers
                                select (Digit: strings[n], Even: (n % 2 == 0));
            // digitOddEvens = {
            // [ Digit : "five", Even : false ],
            // [ Digit : "four", Even : true ],
            // [ Digit : "one", Even : false ],
            // ...
            // }

            //속성 집합으로 출력 생성하기 **
            //Product 객체의 속성 중 ProductName, Category, UnitPrice 속성으로 출력 시퀀스를 만듭니다.
            //특히 UnitPrice 속성을 Price 로 이름을 변경하여 출력 시퀀스를 만들 수도 있습니다.

            List<Product> products = GetProductList();
            var productInfos = from p in products
                               select (p.ProductName, p.Category, Price: p.UnitPrice);

        }

        //인덱스를 활용해 출력 만들기
        {
            //numbers 배열의 속성 중 하나인 index 속성을 Select 절에 활용하여
            //숫자가 자신의 순서에 맞는 위치에 있는지를 확인할 수 있는 출력 시퀀스를 만듭니다.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsInPlace = numbers.Select((num, index) => (Num: num, InPlace: (num == index)));

            // numsInPlace = {
            // [ Num : 5, InPlace : false ],
            // [ Num : 4, InPlace : false ],
            // [ Num : 1, InPlace : false ],
            // [ Num : 3, InPlace : true ],
            // ...
            // }
        }

        //Select 절과 Where 절을 같이 활용하기
        {
            //Select 절과 Where 절을 활용해서 5 이하의 숫자만 출력하는 시퀀스를 만듭니다.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var lowNums = from n in numbers
                          where n < 5
                          select digits[n];
            // { "four", "one", "three", "two", "zero" };


            //여러 입력 시퀀스로부터 하나의 출력 시퀀스 만들기
            //from 절로 numbersA 배열과 numbersB 배열을 입력 시퀀스로 받아
            //pairs 라는 하나의 출력 시퀀스를 만들 수 있습니다.

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select (a, b);
            // { 
            //    [ 0, 1 ], [ 0, 3 ], [ 0, 5 ], [ 0, 7 ], [ 0, 8 ],
            //    [ 2, 3 ], [ 2, 5 ], [ 2, 7 ], [ 2, 8 ],
            //    [ 4, 5 ], [ 4, 7 ], [ 4, 8 ],
            //     ...
            // }
        }

    }

    class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }

    }

    static List<Product> GetProductList()
    {
        List<Product> list = new List<Product>() {
                new Product{Category = "a" , UnitsInStock = 2, UnitPrice = 100},
                new Product{Category = "b" , UnitsInStock = 5, UnitPrice = 200}
            };
        return list;
    }

    public class Student
    {
        public string name { get; set; }
        public int score { get; set; }
    }
}


/*

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
    static List<Customer> GetCustomerList()
    {
        List<Customer> list = new List<Customer>() {
                new Customer{CustomerID = "a" , Region = "WA" },
                new Customer{CustomerID = "b" , Region = "LA" }
            };
        return list;
    }


    //속성으로 필터링하기
    List<Customer> customers = GetCustomerList();
    var waCustomers = from cust in customers
                        where cust.Region == "WA"
                        select cust;


    //서로 연관있는 입력 시퀀스로부터 하나의 출력 시퀀스 만들기
    //customers 리스트와 customers의 속성인 Orders를 입력 시퀀스로 받아, 
    //500 이하인 order 만 모은 출력 시퀀스를 만듭니다.

    List<Customer> customers = GetCustomerList();

    var orders = from c in customers
                    from o in c.Orders
                    where o.Total < 500.00M
                    select (c.CustomerID, o.OrderID, o.Total);


    //1998.01.01 이후 주문만 모은 출력 시퀀스를 만듭니다.

    List<Customer> customers = GetCustomerList();

    var orders = from c in customers
                    from o in c.Orders
                    where o.OrderDate >= new DateTime(1998, 1, 1)
                    select (c.CustomerID, o.OrderID, o.OrderDate);


    //여러 Where 절을 활용해 입력 시퀀스를 제한한 특정한 출력 시퀀스를 만들 수도 있습니다.
    //아래 예제는 고객 중 WA 지역에 살면서 1997.01.01 d이후 주문만 출력하는 시퀀스를 만듭니다.

    List<Customer> customers = GetCustomerList();
    DateTime cutoffDate = new DateTime(1997, 1, 1);
    var orders = from c in customers
                    where c.Region == "WA"
                    from o in c.Orders
                    where o.OrderDate >= cutoffDate
                    select (c.CustomerID, o.OrderID);


    //SelectMany 절     
    //  SelectMany - SQL의 Cross Join과 같이 가능한 모든 조인 집합
    //  아래 예제는 처음 LINQ 를 사용하는 초보자에게 이해하기 어렵습니다. 
    //  '이런 사용 방법도 있구나'하고 넘어가시면 되겠습니다.

    List<Customer> customers = GetCustomerList();

    var customerOrders =
        customers.SelectMany(               
            (cust, custIndex) =>
            cust.Orders.Select(o => 
                "Customer #" + (custIndex + 1) + " has an order with OrderID " + o.OrderID
        ));
*/
