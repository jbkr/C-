//Range, Repeat

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //Range
        //Rnage 메서드는 특정 범위의 숫자 집합을 만들 때 사용하는 메서드입니다.

        var numbers = from n in Enumerable.Range(100, 50)          // 100 - 149 까지
                        select (Number: n, OddEven: n % 2 == 1 ? "odd" : "even");

        //Repeat
        //Repeat 메서드는 특정 숫자를 특정 횟수만큼 반복한 집합을 만들 때 사용하는 메서드입니다.

        var numbers = Enumerable.Repeat(7, 10); 
        // numbers = { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };

    }

}

