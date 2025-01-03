﻿//분할 연산자    Partition Operator
//      LINQ 에서 제공하는 확장 메서드 중
//      Take, Skip, TakeWhile, SkipWhile 을 분할 연산자라 합니다.
//      분할 연산자는 출력 시퀀스를 분할시켜 반환.

using System;
using System.Collections.Generic;
using System.Linq;


class MainApp
{
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

        List<Customer> customers = GetCustomerList();
        var waOrders = from cust in customers
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

    }

}
