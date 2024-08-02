class Program
{
    public class MyClass : IComparable              // 비교 연산 가능 // sorting 가능
    {
        public int CompareTo(object? obj)           
        {
            throw new NotImplementedException();
        }
    }

    static void Main(string[] args)
    {

    }
}