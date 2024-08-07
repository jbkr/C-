using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 123, 456, 789 };

        ArrayList list = new ArrayList(arr);    // 배열로 초기화
        Stack stack = new Stack(arr);
        Queue queue = new Queue(arr);

        //{ "하나", 1}    C# 5.0
        //{ ["하나"], 1}  C# 6.0

        ArrayList list1 = new ArrayList(arr) { [1] = 100 };

        //h3[1] = "one";
        //h3[1] = "1";      // 덮어쓰기
    }
}