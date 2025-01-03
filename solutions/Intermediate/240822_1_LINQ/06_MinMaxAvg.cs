//메서드 사용
// Count, Max, Min, Average

using System;
using System.Linq;

namespace MinMaxAvg
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
                new Profile(){Name="A", Height=186},
                new Profile(){Name="B", Height=158},
                new Profile(){Name="C", Height=172},
                new Profile(){Name="D", Height=178},
                new Profile(){Name="E", Height=171}
            };

            // 175미만,175이상 그룹으로 나누고,  Count, Max, Min, Average 를 구하라. 

            var heightStat = from profile in arrProfile
                           group profile by profile.Height < 175 into  g
                           select new
                           {
                               Group   = g.Key==true?"175미만":"175이상",
                               Count   = g.Count(),
                               Max     = g.Max(profile => profile.Height),
                               Min     = g.Min(profile => profile.Height),
                               Average = g.Average(profile => profile.Height)
                           };

            foreach (var stat in heightStat)
            {
                Console.Write("{0} - Count:{1}, Max:{2}, ", stat.Group, stat.Count, stat.Max);
                Console.WriteLine("Min:{0}, Average:{1}", stat.Min, stat.Average);
            }
        }
    }
}
