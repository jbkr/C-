class Program
{
    static void Main(string[] args)
    {
        Directory.CreateDirectory(Directory.GetCurrentDirectory());
        string? path = null;
        File.Exists(path);

        Stream outStream = new FileStream("a.dat", FileMode.Create);
    }
}