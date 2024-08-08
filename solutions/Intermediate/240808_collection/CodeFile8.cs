class Program
{
    class TestA<T> where T : Player, ICloneable { }     // 동시 만족

    class Player : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    class NPC : Player { }

    static void Main(string[] args)
    {
        TestA<Player> a = new TestA<Player>();
        TestA<NPC> b = new TestA<NPC>();
    }
}