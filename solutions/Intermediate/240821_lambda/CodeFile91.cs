// class

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

        // 175 미만
        var profiles = from profile in arrProfile
                       where profile.Height < 175
                       orderby profile.Height descending
                       //select profile;
                       select new       // 익명 타입
                       {
                           Name = profile.Name,
                           InchHeight = profile.Height * 0.393,
                       };

        foreach (var profile in profiles) Console.WriteLine(profile.Name + " " + profile.InchHeight);


    }
}