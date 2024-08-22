// group by into
// 쓸 일 없다

class Program
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
            new Profile(){Name="우성",Height=185},
            new Profile(){Name="태희",Height=158},
            new Profile(){Name="현정",Height=172},
            new Profile(){Name="문세",Height=178},
            new Profile(){Name="동훈",Height=171}
        };

        var listProfile = from p in arrProfile
                          orderby p.Height
                          group p by p.Height < 175 into g
                          select new
                          {
                              GroupKey = g.Key,
                              Profiles = g
                          };
        foreach (var Group in listProfile)
        {
            Console.WriteLine($"175 미만? : {Group.GroupKey}");
            foreach (var profile in Group.Profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");
            }
        }
    }
}