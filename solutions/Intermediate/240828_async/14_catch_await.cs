// catch/finally 블럭에서 await 사용
//      catch 블럭에서 일반적으로 에러를 로깅을 하는 경우가 많은데,
//      이 때 로깅처리를 비동기적으로 하기 위해 await를 사용할 수 있다.

using System;
{
    IDbConnection conn;
    try
    {
        //...
        var response = await req.GetResponseAsync();
        //...
    }
    catch (Exception ex)
    {
        //에러를 비동기로 로깅
        await Log(ex);
    }
    finally
    {
        //Close를 비동기로 처리
        await Close(conn);
    }
}

