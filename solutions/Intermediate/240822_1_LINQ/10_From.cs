//from where

using System;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        // 짝수만 골라 출력하세요 
        int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

        var result = from n in numbers
                        where n % 2 == 0
                        orderby n 
                        select n;              // IEnumerable

        foreach (int n in result)
            Console.WriteLine($"짝수 : {n}");
    }
}


/*
    //10보다 작은 짝수, 내림차순 -------------------------------------    
    int[] numbers = { 1, 3, 4, 6, 5, 9, 8, 12, 15, 18, 17, 11, 22 }; 
    var data = from num in numbers 
                where num < 10 && num % 2 == 0 
                orderby num descending
                select num;

    //영문자만 -----------------------------------------------------
    char[] chars = "str12i3!@$1ng".ToCharArray();

    var data = from vchar in chars
               where vchar >= 97 && 122 >= vchar
               select vchar;

    foreach (char i in data)
        Console.Write("{0}", i);
*/