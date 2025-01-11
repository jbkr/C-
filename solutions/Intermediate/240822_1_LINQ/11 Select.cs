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



