class Program
{
    class SquareCalculator
    {
        //public int this[int index]          // 인덱서 -> 반환형 this[ 매개변수 ] 구현
        //{
        //    get { return index * index; }
        //}
        public int this[int index] => index * index;
        public int this[string a] => a.Length;      // int 이외
    }

    static void Main(string[] args)
    {
        SquareCalculator squareCalculator = new SquareCalculator();
        Console.WriteLine(squareCalculator[5]);
        Console.WriteLine(squareCalculator[10]);
        Console.WriteLine(squareCalculator["Hello"]);
    }
}
