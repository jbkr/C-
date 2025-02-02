class Program
{
    class MyClass
    {
        public string Name { get; set; } = "none";      // prop + tab
        //public string Name { get; } = "none";   // 읽기 전용
        //public string Name { get; private set; } = "none";    // 읽기 전용

        int level = 1;
        public int Level
        {
            get { return level; }
            set
            {
                if (value > 100) return;    // 방어 코드
                level = value;
            }
        }
    }

    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Name = "test";  // Error
        obj.Level = 200;    // 100
        Console.WriteLine(obj.Name);
        Console.WriteLine(obj.Level);
    }
}