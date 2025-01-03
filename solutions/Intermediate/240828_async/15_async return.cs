//async 커스텀 리턴 타입

// async / await는
//      void, Task, Task<T> 등 3가지 리턴 타입만을 가질 수 있었는데
//      Task는 리턴값이 없는 비동기 메서드를 위해서 사용되었고,
//      Task<T>는 리턴값 T를 갖는 비동기 메서드를 위해 사용되었다.
//      void는 주로 이벤트핸들러를 위해 사용되었지만
//      메서드 내부에서 Unhandled Exception이 발생하면 프로세스를 다운시키는 문제가 있어서 사용을 자제한 리턴타입이다.

// C# 7 에서는 이러한 3가지 async 리턴타입에 대한 제약을 넘어 커스텀 리턴 타입을 허용
//      커스텀 타입은 async 패턴에 맞게 정의되어야 한다.
//      Custom 리턴 타입의 하나로 .NET Framework에서 ValueTask<T> 라는 타입이 제공
//      Nuget 패키지에서 System.Threading.Tasks.Extensions 을 설치


//ValueTask<T>
//  async 메서드 내에서
//  동기 처리가 필요할 때는 Task 객체를 생성하지 않고 직접 값 T 를 리턴하고,
//  비동기 처리가 필요할 때는 Task 객체를 생성하여 사용
//  성능 향상

using System.Collections.Generic;

private Dictionary<int, int> cache = new Dictionary<int, int>();

private async ValueTask<int> GetCache(int id)
{
    if (cache.ContainsKey(id))
    {
        // 동기 처리. 값 직접 리턴
        return cache[id];
    }
    else
    {
        // 비동기 처리. Task 객체 생성
        int res = await Fetch(id);
        cache.Add(id, res);
        return res;
    }
}