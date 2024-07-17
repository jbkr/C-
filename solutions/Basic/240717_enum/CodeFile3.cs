enum Item
{
    coffee,         // 0 부터 시작, 1씩 증가
    tea,            // 지정 가능
    bread,
    ice
}

class Program
{

    static void Main(string[] args)
    {
        Item item = Item.coffee;
        item = Item.tea;
        int num = (int)item;        // 1
    }

}
