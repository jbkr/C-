// 집합 연산자 Distinct, Union, Intersect, Except

class Program
{
    static void Main(string[] args)
    {
        int[] factorsOf300 = { 2, 2, 3, 5, 5 };
        var uniqueFactors = factorsOf300.Distinct();    // 중복 요소 제거하기
        // { 2, 3, 5 }

        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };
        var uniqueNumbers = numbersA.Union(numbersB);   // 합집합 만들기

        int[] numbers1 = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbers2 = { 1, 3, 5, 7, 8 };
        var commonNumbers = numbers1.Intersect(numbers2);    // 교집합

        int[] numbersA1 = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB2 = { 1, 3, 5, 7, 8 };
        var aOnlyNumbers = numbersA1.Except(numbersB2); // 차집합
    }
}