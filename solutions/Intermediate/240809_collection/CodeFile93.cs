// throw

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
            throw new Exception("예외 발생");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}