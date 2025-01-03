//확장 메서드 방식으로 사용하기

using System;
using System.Linq;

namespace SimpleLinq2
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile = 
            {
                new Profile() { Name="우성", Height=186 },
                new Profile() { Name="태희", Height=158 },
                new Profile() { Name="현정", Height=172 },
                new Profile() { Name="문세", Height=178 },
                new Profile() { Name="하하", Height=171 }
            };

            //확장 메서드 방식으로 사용하기
            var profiles = arrProfile.
                              Where(profile => profile.Height < 175).
                              OrderBy(profile => profile.Height).
                              Select(profile =>
                                     new
                                     {
                                         Name = profile.Name,
                                         InchHeight = profile.Height * 0.393
                                     });

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}
