// callback
// window popup

class Program
{
    class MyWindow  // 함수 전달 - 클릭하면 함수 실행
    {
        public Action callback;     // 함수(void()) 저장

        public MyWindow(Action func) { callback = func; }   // 생성자, 초기화, Start

        public void Update()    // 루프, Update
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (callback != null) callback();
                }
            }
        }
    }

    static void CallMe() { Console.WriteLine("Enter"); }

    static void Main(string[] args)
    {
        MyWindow myWindow = new MyWindow(CallMe);
        myWindow.Update();
    }
}