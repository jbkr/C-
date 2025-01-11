//변환 연산자 Conversion Operators  
//  ToList, ToArray, ToDictionary

//  LINQ 구문은 IEnumerable 인터페이스를 반환합니다.
//  하지만 코드를 작성하다보면 인터페이스가 아닌 구체화된 클래스가 필요할 때가 있습니다.
//  그 때 변환 연산자를 활용하여 Array, List, Dictionary 타입으로 변환할 수 있습니다

//  변환 연산자를 사용하게 되면 바로 연산을 끝내기 때문에
//  연산이 많은 LINQ 구문은 성능에 영향을 미칠 수 있습니다


using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //ToArray

        double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
        var sortedDoubles = from d in doubles
                            orderby d descending
                            select d;
        var doublesArray = sortedDoubles.ToArray();


        //ToList

        string[] words = { "cherry", "apple", "blueberry" };
        var sortedWords = from w in words
                            orderby w
                            select w;
        var wordList = sortedWords.ToList();


        //ToDictionary
                       
        var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                            new {Name = "Bob"  , Score = 40},
                            new {Name = "Cathy", Score = 45}                                        };
        var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);


        //OfType 
        //  numbers 배열의 모든 요소를 double 로 형변환합니다.

        object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };
        var doubles1 = numbers.OfType<double>();
        foreach ( var item in doubles1 )
        {
            Console.WriteLine(item);
        }
        // doubles1 = { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0 };

    }

}

