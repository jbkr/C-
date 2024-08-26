﻿//시퀀스 작업 Sequence operations   
//  SequenceEqual, Concat, Zip

using System;
using System.Collections.Generic;
using System.Linq;


class MainApp
{
    static void Main(string[] args)
    {
        //SequenceEqual
        //  두 집합의 모든 요소가 같은 순서대로 있는지 비교하기

        var wordsA = new string[] { "cherry", "apple", "blueberry" };
        var wordsB = new string[] { "cherry", "apple", "blueberry" };
        bool match = wordsA.SequenceEqual(wordsB);
        // match = true


        // 순서를 변경하면 결과가 달라집니다.
        var wordsA = new string[] { "cherry", "apple", "blueberry" };            
        var wordsB = new string[] { "apple", "blueberry", "cherry" };
        bool match = wordsA.SequenceEqual(wordsB);
        // match = false


        //Concat
        //  두 집합 연결하기

        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var allNumbers = numbersA.Concat(numbersB);
        // allNumbers = { 0, 2, 4, 5, 6, 8, 9, 1, 3, 5, 7, 8 }


        //Zip
        //  Enumerable.Zip
        //  Enumerable.Zip 메서드는 집합 A의 모든 요소와 집합 B의 모든 요소와 하나하나 대조하여 연결하는 메서드입니다.
        //  주로 수학에서 벡터의 내적 곱을 계산할 때 사용됩니다.

        int[] vectorA = { 0, 2, 4, 5, 6 };
        int[] vectorB = { 1, 3, 5, 7, 8 };
        int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();
            // dotProduct = 109

    }
}
