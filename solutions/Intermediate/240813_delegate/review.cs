class InputManager
{
    public delegate void Action();
    public event Action enterAction;
    public event Action escAction;
    public void Update()
    {
        if (Console.KeyAvailable == false) return;
        ConsoleKeyInfo info = Console.ReadKey();
        if (info.Key == ConsoleKey.Enter)
        {
            enterAction();
        }
        if (info.Key == ConsoleKey.Escape)
        {
            escAction();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InputManager inputManager = new InputManager();
        inputManager.enterAction += OnEnter;
        inputManager.escAction += OnEsc;
        inputManager.Update();
    }

    static void OnEnter()
    {
        Console.WriteLine("Enter pressed");
    }

    static void OnEsc()
    {
        Console.WriteLine("ESC pressed");
    }
}