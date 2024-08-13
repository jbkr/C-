// button - interface
// button - 기능 별 구현 X

class MyButton
{
    public string Text;                     // 텍스트 ( 버튼 이름 )
    public event EventHandler Click;        // 함수 ( 기능 )

    public void MouseButtonDown()
    {
        if (this.Click != null)
        {
            Click(this, EventArgs.Empty);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyButton button = new MyButton();
        button.Click += new EventHandler(btn_Click);
        button.Text = "Run";
        //...
        button.MouseButtonDown();
    }

    static void btn_Click(object sender, EventArgs e)
    {
        //MyButton button = sender as MyButton;
        Console.WriteLine("Click");
        //
    }
}