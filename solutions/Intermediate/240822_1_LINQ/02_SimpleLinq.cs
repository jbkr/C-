// class member 애 대하여 링큐 사용해보기 ------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCSharp
{

    class MainApp
    {
        class Profile
        {
            public string Name { get; set; }
            public int Height { get; set; }
        }

        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="우성", Height=186},
                new Profile(){Name="태희", Height=158},
                new Profile(){Name="현정", Height=172},
                new Profile(){Name="문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };
            
            // 175 미만인 경우를 정렬하자

            List<Profile> profiles = new List<Profile>();
            foreach (var item in arrProfile)
            {
                if (item.Height < 175) profiles.Add(item);
            }
            profiles.Sort((x, y) => { return x.Height - y.Height; });

  
            //링큐로 변경하자

            var profiles = from profile in arrProfile
                        where profile.Height < 175
                        orderby profile.Height
                        select profile;
/*
            var profiles = from profile in arrProfile
                        where profile.Height < 175
                        orderby profile.Height descending  //내림차순
                        select profile;
*/

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.Height}");
        }
        
    }
}


// 맴버 추가( 이름, 점수), 정렬, 검색 하기
//    class Members
//    {
//    }
