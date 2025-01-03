//Count

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //Count
        //  집합 내 요소 개수 세기

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        int oddNumbers = numbers.Count(n => n % 2 == 1);
        // oddNumbers = 5;


        //Distinct
        //  집합 내 조건에 맞는 요소 개수 세기

        //메서드로 중복되는 값인 2와 5를 하나씩 제거한 뒤, 개수를 셉니다.
        int[] factorsOf300 = { 2, 2, 3, 5, 5 };
        int uniqueFactors = factorsOf300.Distinct().Count();
        // uniqueFactors = 3



        //쿼리 문 내에서 그룹 개수 세기

        List<Customer> customers = GetCustomerList();
        var orderCounts = from c in customers
                            select (c.CustomerID, OrderCount: c.Orders.Count());
        //각 Customers 별로 Order가 몇개 있는지 셉니다.
                        
        List<Product> products = GetProductList();
        var categoryCounts = from p in products
                                group p by p.Category into g
                                select (Category: g.Key, ProductCount: g.Count());
        //Category 별로 해당하는 Product가 몇 개 있는지 셉니다.

    }

}

