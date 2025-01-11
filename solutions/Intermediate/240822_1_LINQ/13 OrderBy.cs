//정렬 연산자 Ordering Operator
//  정렬 연산자인 OrderBy는
//  당연히 출력 시퀀스를 기준에 따라 정렬하는 연산자입니다.
//  자주 사용하는 연산자

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //원소 정렬하기
        string[] words = { "cherry", "apple", "blueberry" }; 
        var sortedWords = from word in words 
                            orderby word 
                            select word; 
        // { "apple", "blueberry", "cherry" };
            

        //원소의 속성으로 정렬하기
        string[] words = { "cherry", "apple", "blueberry" }; 
        var sortedWords = from word in words 
                            orderby word.Length 
                            select word; 
        // { "apple", "cherry", "blueberry" }
            

        //클래스의 속성으로 정렬하기
        //List<Product> products = GetProductList();
        //var sortedProducts = from prod in products orderby prod.ProductName select prod;
            

        //내림차순으로 정렬하기
        double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
        var sortedDoubles = from d in doubles 
                            orderby d descending 
                            select d; 
        // { 4.1, 2.9, 2.3, 1.9, 1.7 }
            

        //여러 기준으로 정렬하기 ***

        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
        var sortedDigits = from digit in digits 
                            orderby digit.Length, digit 
                            select digit; 
        // { // "one", "six", "two", // "five", "four", "nine", "zero", // "eight", "seven", "three" // }
            
        List<Product> products = GetProductList();
        var sortedProducts = from prod in products 
                                orderby prod.Category, prod.UnitPrice descending 
                                select prod;


        //Reverse()
        //  정렬 뒤집기  

        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
        var reversedIDigits = (from digit in digits where digit[1] == 'i' select digit).Reverse();
        // { "nine", "eight", "six", "five" };



        //OrderBy()
        //  비교 연산자를 구현해 활용하기  

        string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
        // sortedWords = { "AbAcUs", "aPPLE", "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr" }

        // OrderByDescending

        string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
        // sortedWords = { "ClOvEr", "cHeRry", "bRaNcH", "BlUeBeRrY", "aPPLE", "AbAcUs" }


        //ThenBy
        //  비교 연산자를 중첩해서 사용하기

        string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedWords = words
            .OrderBy(a => a.Length)
            .ThenBy(a => a, new CaseInsensitiveComparer());
        // { 
        //     "aPPLE",
        //     "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr",
        //     "BlUeBeRrY"
        // }

        //ThenByDescending 

        string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedWords = words
            .OrderBy(a => a.Length)
            .ThenByDescending(a => a, new CaseInsensitiveComparer());
        // { 
        //     "BlUeBeRrY"
        //     "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr",
        //     "aPPLE",
        // }

    }
    // expression body definition
    public class CaseInsensitiveComparer : IComparer<string> 
    { 
        public int Compare(string x, string y) => 
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase); }
    }
}