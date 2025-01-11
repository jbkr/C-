//집계 작업 Aggregators   
//  Count, Sum, Min, Max, Average, Aggregate

//  집계 작업은 집합 모든 요소를 계산하여 하나의 값으로 반환하는 작업입니다.


using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        // Aggregate

        //기본적인 사용방법
        double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
        double product = doubles.Aggregate((running, next) => running * next);
        Console.WriteLine(product); 
        // product = 88.33080999999999  // 1.7 * 2.3 * 1.9 * 4.1 * 2.9

        string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
        string line = fruits.Aggregate((line, fruit) => line + ", " + fruit);
        // line = apple, mango, orange, passionfruit, grape

        //Enumerable.Aggregate 메서드는
        //  위 예제와 같이 foreach 문보다 짧고 간결하게 string을 연결하여 문장을 만들 수 있습니다.


        //Average

        //집합 내에서 평균값 계산하기
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        double averageNum = numbers.Average();
        // averageNum = 4.5                       
            
        //집합 내 원소를 활용하여 평균값 계산하기
        string[] words = { "cherry", "apple", "blueberry" };
        double averageLength = words.Average(w => w.Length);
        // averageLength = 6.666666666666667
                        
        //그룹 별로 평균값 계산하기
        List<Product> products = GetProductList();
        var categories = from p in products
                            group p by p.Category into g
                            select (Category: g.Key, AveragePrice: g.Average(p => p.UnitPrice));

        //Sum

        //집합 내 모든 원소 더하기
        int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        double numSum = numbers1.Sum();
        // numSum = 45
                        
        //집합 내 원소를 활용하여 더하기
        string[] words1 = { "cherry", "apple", "blueberry" };
        double totalChars = words1.Sum(w => w.Length);
        // totalChars = 20


        //Max

        //집합 내에 최댓값 찾기
        int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        int maxNum = numbers2.Max();
        // maxNum = 9
            
        //집합 내 원소를 사용하여 최댓값 찾기
        string[] words2 = { "cherry", "apple", "blueberry" };
        int longestLength = words2.Max(w => w.Length);
        // longestLength = 9


        //그룹 내에서 최댓값 찾기
        List<Product> products1 = GetProductList();
        var categories1 = from p in products1
                            group p by p.Category into g
                            select (Category: g.Key, MostExpensivePrice: g.Max(p => p.UnitPrice));

        List<Product> products2 = GetProductList();
        var categories2 = from p in products2
                            group p by p.Category into g
                            let maxPrice = g.Max(p => p.UnitPrice)
                            select (Category: g.Key, MostExpensiveProducts: g.Where(p => p.UnitPrice == maxPrice));

    }

    class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }
    static List<Product> GetProductList()
    {
        List<Product> list = new List<Product>() {
            new Product{Category = "a" , UnitPrice = 2 },
            new Product{Category = "a" , UnitPrice = 5 },
            new Product{Category = "b" , UnitPrice = 5 }
        };
        return list;
    }
}
