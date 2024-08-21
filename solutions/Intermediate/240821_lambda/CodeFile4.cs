// callback
// window popup

class Program
{
    class MyWindow  // 함수 전달 - 클릭하면 함수 실행
    {
        public Action<string> callback;     // 함수(void(string)) 저장

        public MyWindow(Action<string> func) { callback = func; }   // 생성자, 초기화, Start

        public void Update()    // 루프, Update
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (callback != null) callback("yes");
                }
                if (keyInfo.Key == ConsoleKey.N)
                {
                    if (callback != null) callback("no");
                }
            }
        }
    }

    static void CallMe() { Console.WriteLine("Enter"); }

    static void Main(string[] args)
    {
        MyWindow myWindow = new MyWindow((string rt) =>
        {
            if (rt == "yes") Console.WriteLine("Yes");
            if (rt == "no") Console.WriteLine("No");
        });
        myWindow.Update();
    }
}