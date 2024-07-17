enum PlayerState
{
    idle,
    walk,
    run,
    jump,
    hit,
    die
}

class Player
{
    //int state = 1;                      // 1:기본, 2:걷기, 3:뛰기, 점프, 데미지 ( 상태 )
    PlayerState state = PlayerState.idle;

    void SetAnim()
    {
        switch (state)
        {
            case PlayerState.idle:
                break;
            default:
                break
        }
    }
}

class Program
{

    static void Main(string[] args)
    {


    }

}
