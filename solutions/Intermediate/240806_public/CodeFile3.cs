class Program
{
    class MyClass
    {
        //int myField;    // 은닉   // 변수
        //public int GetMyField() { return myField; }
        //public void SetMyField(int a) { myField = a; }

        private int myField;    // 변수
        public int MyField      // 함수
        {
            get { return myField; }
            set { myField = value; }
        }


        //int level = 0;
        //public int GetLevel() { return level; }
        //public void SetLevel(int a) { level = a; }    // 번거롭다

        public int Level { get; set; }   // 프로퍼티
    }

    static void Main(string[] args)
    {
        MyClass obj = new MyClass();

        //obj.SetMyField(1);
        //Console.WriteLine(obj.GetMyField());
        obj.MyField = 1;
        Console.WriteLine(obj.MyField);

        obj.Level = 1;  // 사용 - 변수와 동일  // 함수처럼 취급 ( get set )  => 정보 은닉(캡슐화) + 사용 편의
        Console.WriteLine(obj.Level);
    }
}