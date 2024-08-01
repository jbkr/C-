// 중첩 클래스
// 멤버 클래스

class Out                       // internal -> public
{
    int num = 0;
    In aa;

    void Func()
    {
        num++;
        In i = new In();
    }

    class In                    // private
    {
        int x;
        void Func()
        {
            x++;
            Out o = new Out();
            o.num++;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Out o = new Out();
        //In a = new In();        // private
        //Out.In aa = new In();   // public

    }
}