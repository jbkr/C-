//새로운 타입의 인스턴스로 만들기 (익명형식)

using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
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

            //새로운 타입의 인스턴스로 만들기 (익명형식) ***

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}
