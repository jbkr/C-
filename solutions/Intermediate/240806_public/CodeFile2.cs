class Program
{
    class MyClass
    {
        //int myField;    // 은닉   // 변수
        public int myField;
        //public int GetMyField() { return myField; }
        //public void setMyField(int a) { myField = a; }

        void Func() { myField++; }
    }

    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.myField = 1;        // 외부에서 변경
        Console.WriteLine(obj.myField);
    }
}