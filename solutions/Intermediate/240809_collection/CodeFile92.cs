class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //catch (Exception ex)
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);  // 다운되지 않게 조치
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);  // 다운되지 않게 조치
        }
        Console.WriteLine("end");
    }
}