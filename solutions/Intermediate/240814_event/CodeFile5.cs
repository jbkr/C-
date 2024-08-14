// 문 형식
// ( 매개변수 ) => { 문장 }

delegate void Doit();

class Program
{
    static void Main(string[] args)
    {
        Doit helloWorld = () =>
        {
            Console.WriteLine("Hello World");
        };

        helloWorld();
    }
}