// dynamic
// runtime type
// a = ?

class Program
{
    class MyClass
    {
        public void FuncAAA() { }
    }

    static void Main(string[] args)
    {
        dynamic obj= new MyClass();
        obj.FuncAAA();
        obj.FuncBBB();
    }
}