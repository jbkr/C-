// singleton
// 유일한 객체
// game info, sound manager ( pattern )

class Singleton
{
    //public Singleton() { }

    // ===== singleton code =====
    private Singleton() { }
    static Singleton instance = null;
    public static Singleton Instance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
    // ==========================

    //
    public string Version = "V 1.0";
    public void Show() { }
    public void Play() { }
}

class Program
{
    static void Main(string[] args)
    {
        //Singleton singleton1 = new Singleton();
        //Singleton singleton2 = new Singleton();
        //Singleton singleton3 = new Singleton();
        Singleton.Instance().Show();
        Singleton.Instance().Play();
    }
}