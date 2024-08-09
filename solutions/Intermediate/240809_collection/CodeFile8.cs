using System.Collections;

class Program: Monobehavior
{
    GameObject go;      // null
    Coroutine co;

    void Start()
    {
        Debug.log("Hello");
        print("Hello");

        go.transform.parent = transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escaple))
        {
            // 3초 뒤에 "Hello" 출력
            co = StartCoroutine("Func");
            StopCoroutine(co);
        }

        transform.position += Vector3.right * Time.deltaTime * 0.2f;
    }

    IEnumerator Func()
    {
        yield return new WaitForSeconds(3.0f);
    }
}