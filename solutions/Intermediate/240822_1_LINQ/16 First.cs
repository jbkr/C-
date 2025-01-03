//��� ������ Element Operators  
//      First, FirstOrDefault, ElementAt
//      ��� �����ڴ� LINQ ���� ������� ���ϴ� ��ġ�� ��� �ϳ��� ������ �� ����ϴ� �������Դϴ�.
//      ���� ������ orderby �� ���� ����ϴ� ��찡 �����ϴ�.

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //First
        //  �־��� �������� �˻��� ù ��° ��� ã��

        List<Product> products = GetProductList();

        Product product12 = (from p in products where p.ProductID == 12
                             select p)
                             .First();
        //products ����Ʈ���� ProductID�� 12�� ��� �� ù ��°�� �˻��� ��Ұ� product12 ������ �Ҵ�˴ϴ�.

        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string startsWithO = strings.First(s => s[0] == 'o');
        // startsWith0 = "one";

        //strings �迭���� ���ĺ� 'o'�� �����ϴ� �ܾ� �� ù ��°�� �˻��� �ܾ� "one" �� startsWithO �� �Ҵ�˴ϴ�.


        //FirstOrDefault
        //  �־��� ���ǿ� �´� ù ��° ��Ұ� ���� ��� ����Ʈ �� �ޱ�
        //  ���� �Է� �������� ��� �ְų� ���ǿ� �´� ���� ���� ���, ����Ʈ ���� ��ȯ�մϴ�.

        int[] numbers = { };
        int firstNumOrDefault = numbers.FirstOrDefault();
        // numbers �迭�� ��� �����Ƿ� int�� ����Ʈ ���� 0 �� �Ҵ��մϴ�.
        // firstNumOrDefault = 0;
            
        List<Product> products = GetProductList();
        Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
        // ���� products ����Ʈ�� ProductID �Ӽ��� 789�� ��Ұ� ���� ���, �ش� ��Ҹ� ��ȯ�մϴ�.
        //���� ���, Product �⺻ �����ڷ� ������ ��ü�� ��ȯ�մϴ�.


        //ElementAt
        //  Ư�� ��ġ�� �ִ� ��� ã��

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        int fourthLowNum = (
            from n in numbers
            where n > 5
            select n)
            .ElementAt(1);

        // numbers �迭 �� 5 ���� ū �迭�� { 9, 8, 6, 7 }
        // ���� [1]�� ��ġ�� ���� 8 �̹Ƿ�,
        // fourthLowNum =  8;

    } 
} 
