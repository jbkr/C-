class Program
{
    class TestA<T, U>
        where T : struct
        where U : class
    {
        T a;
        U b;
    }

    class TestB<T> where T : class { }      // reference type

    class TestC<T> where T : struct { }     // value type


    static void Main(string[] args)
    {
        //TestB<int> testB = new TestB<int>;  // Error  // value type
        TestA<int, string> testA = new TestA<int, string>();
        //TestA<Object, string> testA1 = new TestA<object, string>(); // Error
    }
}