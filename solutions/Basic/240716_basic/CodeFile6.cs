class Item { }
class GameObject { }
class Program
{
    static void Main(string[] args)
    {
        //1,2,3,4,5
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] a = new int[5];           // 정식
        a[0] = 1;
        a[1] = 2;

        float[] arr2 = { 1.2f, 1.3f };

        char[] arr3 = { 'a', 'b', 'c' };

        string[] arr4 = { "abc", "def" };
        string[] s = new string[5];

        Item[] items = { new Item() };
        Item[] items1 = new Item[5];

        GameObject[] gameObjects = { new GameObject() };
        GameObject[] gameObjects1 = new GameObject[5];
    }
}