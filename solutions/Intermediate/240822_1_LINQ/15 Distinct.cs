//집합 연산자 Distinct, Union, Intersect, Except

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDistinct
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //Distinct
            //  집합 내에 중복 요소 제거하기

            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            var uniqueFactors = factorsOf300.Distinct();
            // uniqueFactors = { 2, 3, 5 };


            //Union
            //  두 집합에서 중복되지 않게 합집합 만들기

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Union(numbersB);
            // uniqueNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Intersect
            //  두 집합 간에 중복되는 요소만 모으기

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var commonNumbers = numbersA.Intersect(numbersB);
            // commonNumbers = { 5 , 8 };


            //Except
            //  A 집합에는 있지만 B 집합에는 없는 요소만 모으기

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);
            // aOnlyNumbers = { 0, 2, 4, 6, 9 } ;
        }

    }

}
