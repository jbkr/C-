using System;
using System.Linq;

namespace GroupBy
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //바구니에 나눠 담기 
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numberGroups = from n in numbers
                               group n by n % 5 into g      //5로 나눈 나머지를 기준으로 그룹
                               select (Remainder: g.Key, Numbers: g);

            foreach (var item in numberGroups)
            {
                Console.Write(item.Remainder); Console.Write(" : ");
                foreach (var a in item.Numbers) { Console.Write(a); Console.Write(" "); }
                Console.WriteLine();
            }
            // numberGroups = { 
            // { 0 : [ 5, 0 ] }, 
            // { 4 : [ 4, 9 ] }, 
            // { 1 : [ 1, 6 ] }, 
            // { 3 : [ 3, 8 ] }, 
            // { 2 : [ 7, 2 ] }, 
            //}

            //속성 값을 기준으로 바구니에 나눠담기
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" }; 
            var wordGroups = from w in words 
                             group w by w[0] into g 
                             select (FirstLetter: g.Key, Words: g);
            foreach (var item in wordGroups)
            {
                Console.Write(item.FirstLetter); Console.Write(" ");
                foreach (var a in item.Words) { Console.Write(a); Console.Write(","); }
                Console.WriteLine();
            }

            // wordGroups = { 
            // { b : [ "blueberry", "banana" ] }, 
            // { c : [ "chimpanzee", "cheese" ] }, 
            // { a : [ "abacus", "apple" ] }, 
            // }


            ////속성 값을 기준으로 바구니에 나눠담기
            //List<Product> products = GetProductList(); 
            //var orderGroups = from p in products 
            //                  group p by p.Category into g 
            //                  select (Category: g.Key, Products: g);
            
            ////그룹 연산자를 중첩하여 사용
            //List<Customer> customers = GetCustomerList(); 
            //var customerOrderGroups = from c in customers 
            //                          select (c.CompanyName, YearGroups: 
            //                              from o in c.Orders 
            //                              group o by o.OrderDate.Year into yg 
            //                              select (Year: yg.Key, MonthGroups: 
            //                                  from o in yg 
            //                                  group o by o.OrderDate.Month into mg 
            //                                  select (Month: mg.Key, Orders: mg)
            //                                  ));

            // IEqualityComparer<T>

            string[] anagrams = { "from ", " salt", " earn ", " last ", " near ", " form " };
            var orderGroups =
                anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
            // orderGroups = { 
            // { from : [ from, form ] }, 
            // { salt : [ salt, last ] }, 
            // { earn : [ earn, near ] } 
            // }

            string[] anagrams2 = { "from ", " salt", " earn ", " last ", " near ", " form " };
            var orderGroups2 =
                anagrams.GroupBy(w => w.Trim(), a => a.ToUpper(), new AnagramEqualityComparer());
            // orderGroups = { 
            // { from : [ FROM, FORM ] }, 
            // { salt : [ SALT, LAST ] }, 
            // { earn : [ EARN, NEAR ] } 
            // }
        }

        public class AnagramEqualityComparer : IEqualityComparer<string> 
        {
            public bool Equals(string x, string y) => getCanonicalString(x) == getCanonicalString(y); 
            public int GetHashCode(string obj) => getCanonicalString(obj).GetHashCode(); 

            private string getCanonicalString(string word) 
            { 
                char[] wordChars = word.ToCharArray(); 
                Array.Sort<char>(wordChars); 
                return new string(wordChars); 
            } 
        }
    }
}
