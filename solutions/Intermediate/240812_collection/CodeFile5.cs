// exception
// c# -> runtime error
// stacktrace
// F9 BreakPoint

using System;
class Program
{
    static void Main(string[] args)
    {
		try
		{
			int a = 1;
            Console.WriteLine(3/--a);
        }
		catch (DivideByZeroException e)
		{
            //e.Message
            Console.WriteLine(e.StackTrace);    // BreakPoint   // F9 -> F5
        }
    }
}