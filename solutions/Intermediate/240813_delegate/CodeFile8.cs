class MyNotifier
{
    //public EventHandler some;     // event
    public event EventHandler some;     // event

    public void Func()
    {
        some(null, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyNotifier myNotifier = new MyNotifier();
        // void EventHandler(object? sender, EventArgs e);
        //myNotifier.some(null, EventArgs.Empty);     // 이벤트는 외부에서 호출할 수 없다 - 이벤트는 통지의 의미
        myNotifier.some += null;    // += 등록, 구독
    }
}