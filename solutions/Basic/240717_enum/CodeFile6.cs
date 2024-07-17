class Player { }
class Program
{
    //void Func(var a) { }    
    static void Main(string[] args)
    {
        string s = null;
        object o = null;
        Player p = null;

        //int n = null;
        //if(n == null) { }

        int? n = null;      // nullable type    // null로 초기화 가능     // value type의 null처리
        if (n.HasValue == true) { }
        Nullable<int> v = null;

        int a= 0;
    }

}
