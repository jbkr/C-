// callback
// window popup

class Program
{
    class MyWindow  // 함수 전달 - 클릭하면 함수 실행
    {
        public Action callback_yes;     // 함수(void()) 저장
        public Action callback_no;     // 함수(void()) 저장

        public MyWindow(Action yes_func, Action no_func)
        {
            callback_yes = yes_func;
            callback_no = no_func;
        }   // 생성자, 초기화, Start

        public void Update()    // 루프, Update
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (callback_yes != null) callback_yes();
                }
                if (keyInfo.Key == ConsoleKey.N)
                {
                    if (callback_no != null) callback_no();
                }
            }
        }
    }

    //static void CallMe() { Console.WriteLine("Enter"); }

    static void Main(string[] args)
    {
        //MyWindow myWindow = new MyWindow(CallMe);
        MyWindow myWindow = new MyWindow(() => { Console.WriteLine("Yes"); }, () => { Console.WriteLine("No"); });
        myWindow.Update();
    }
}