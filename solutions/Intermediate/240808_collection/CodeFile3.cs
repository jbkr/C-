class Program
{
    static void Func<T>(T a) { Console.WriteLine(a); }

    class Top<T>
    {
        private T data = default(T);
        public void SetData(T data) { this.data = data; }
        public T GetData() { return this.data; }
    }

    static void Main(string[] args)
    {
        Func<int>(3);
        Func<string>("Hello");

        // 모두 다른 클래스
        Top<string> top = new Top<string>();
        Top<int> top2 = new Top<int>();
        Top<float> top3 = new Top<float>();
    }
}