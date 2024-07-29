// property
// 함수지만 변수처럼 사용
class Item
{
    public int Id { get; set; }     // 프로퍼티     // getter, setter 편하게 사용

    //int id = 0;
    //public int Id
    //{
    //    get { return id; }
    //    set { id = value; }
    //}
}

class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        item.Id = 1;
        Console.WriteLine(item.Id);
    }
}