// class member 애 대하여 링큐 사용해보기 ------------------

// 맴버 추가( 이름, 점수), 정렬, 검색 하기

//    class Members
//    {
//    }

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
                new Profile(){Name="동훈", Height=171}
            };

            List<Profile> profiles = new List<Profile>();
            foreach (var item in arrProfile)
            {
                if (item.Height < 175) profiles.Add(item);
            }
            profiles.Sort((x, y) => { return x.Height - y.Height; });

/*  
            var profiles = from profile in arrProfile
                        where profile.Height < 175
                        orderby profile.Height
                        select profile;

            var profiles = from profile in arrProfile
                        where profile.Height < 175
                        orderby profile.Height descending  //
                        select profile;
*/

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.Height}");
        }
        
    }
}

