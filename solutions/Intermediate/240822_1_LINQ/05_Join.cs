//합치기

//내부 조인(innerJoin)은 교집합과 비슷합니다. 두 데이터 원본 사이에서 특정 필드를 비교하여 일치하는 데이터를 모아 반환합니다. 
//    from a in A
//    join b in B on a.XXXX equals b.YYYY

//외부 조인(outer joun)은 기본적으로 내부 조인과 비슷합니다. 하지만 외부 조인은 기준이 되는 데이터 원본이 포함됩니다. 
//    from a in A
//    join b in B on a.XXXX equals b.YYYY into data

using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile = 
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}                
            };

            Product[] arrProduct = 
            {
                new Product(){Title="비트",        Star="정우성"},
                new Product(){Title="CF 다수",     Star="김태희"},
                new Product(){Title="아이리스",    Star="김태희"},
                new Product(){Title="모래시계",    Star="고현정"},
                new Product(){Title="Solo 예찬",   Star="이문세"}
            };

            var listProfile = 
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star      //내부 조인
                select new 
                { 
                    Name = profile.Name, 
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine("--- 내부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", 
                    profile.Name, profile.Work, profile.Height);
            }

            listProfile = 
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps  //외부 조인
                from product in ps.DefaultIfEmpty(new Product(){Title="그런거 없음"})
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine();
            Console.WriteLine("--- 외부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm",
                    profile.Name, profile.Work, profile.Height);
            }
        }
    }
}


/*
    class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Score
    {
        public string Name { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Profile[] arrProfile =
            {
                new Profile(){ Name="우성", Age=18 },
                new Profile(){ Name="태희", Age=15 },
                new Profile(){ Name="현정", Age=17 },
            };

            Score[] arrScore =
            {
                new Score(){ Name="태희", Math=88, English=68},
                new Score(){ Name="현정", Math=95, English=75},
                new Score(){ Name="아라", Math=77, English=87},
            };

            var list =
                from profile in arrProfile
                join score in arrScore on profile.Name equals score.Name into ps
                from score in ps.DefaultIfEmpty(new Score() { Math = 0, English = 0 })
                select new
                {
                    Name = profile.Name,
                    Age = profile.Age,
                    Math = score.Math,
                    English = score.English
                };

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }


        }
    } 
*/
