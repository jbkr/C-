//수량자 Quantifiers   // Any All

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //Any
        //  하나라도 조건에 맞는 요소가 있는지 확인하기
        string[] words = { "believe", "relief", "receipt", "field" };
        bool iAfterE = words.Any(w => w.Contains("ei"));
        // iAfterE = true;  //words 배열 안에 "receipt" 는 "ei"를 포함하므로 iAfterE 는 true 가 됩니다.


        //All
        //  모든 요소가 조건에 맞는지 확인하기
        int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
        bool onlyOdd = numbers.All(n => n % 2 == 1);
        // onlyOdd = true;  //numbers 배열에 홀수인 숫자 밖에 존재하지 않으므로 onlyOdd 는 true 가 됩니다.


        //Group 별로 확인하기
        //  그룹 별로 조건에 맞는 요소가 있는지 확인할 수 있습니다.
        List<Product> products = GetProductList();
        var productGroups = from p in products
                            group p by p.Category into g
                            where g.Any(p => p.UnitsInStock == 0)
                            select (Category: g.Key, Products: g);

        //그룹 별로 그룹 내 모든 요소가 조건에 맞는지 확인할 수도 있습니다.
        List<Product> products2 = GetProductList();
        var productGroups2 = from p in products
                            group p by p.Category into g
                            where g.All(p => p.UnitsInStock > 0)
                            select (Category: g.Key, Products: g);
    }

    class Product
    {
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
    }
    static List<Product> GetProductList()
    {
        List<Product> list = new List<Product>() { 
            new Product{Category = "a" , UnitsInStock = 2 },
            new Product{Category = "b" , UnitsInStock = 5 }
        };
        return list;
    }
}