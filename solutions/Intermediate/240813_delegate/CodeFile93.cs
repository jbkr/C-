class InputManager
{
    public delegate void OnInputKey();
    public event OnInputKey InputKey;
    public event OnInputKey EscKey;

    public void Update()
    {
        if (Console.KeyAvailable == false) return;
        ConsoleKeyInfo info = Console.ReadKey();
        if (info.Key == ConsoleKey.Enter)
        {
            InputKey();
        }
        if (info.Key == ConsoleKey.Escape)
        {
            EscKey();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InputManager inputManager = new InputManager();
        inputManager.InputKey += OnInputTest;
        inputManager.EscKey += OnEscTest;

        while (true)
        {
            inputManager.Update();
        }
    }
    static void OnInputTest()
    {
        Console.WriteLine("Input Received");
    }
    static void OnEscTest()
    {
        Console.WriteLine("Input Escape!!!");
    }
}