// indexer
// 객체를 배열처럼 사용
// []
// 일종의 프로퍼티

class MyList
{
    int[] arr;
    public int Length { get { return 10; } }
    public MyList() { arr = new int[10]; }

    public int this[int index]      // 반환형 this[ 매개변수 ] -> this 프로퍼티 -> indexer
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList list = new MyList();
        //list.arr[0] = 1;
        //list.Add(1);
        list[0] = 2;      // 배열처럼 사용 -> 인덱서
        list[1] = 3;
        list[2] = 4;
        Console.WriteLine(list[0]);

        for (int i = 1; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }

    }
}