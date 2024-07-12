while (true)
{
    Console.WriteLine("Enter a number");
    //int n = int.Parse(Console.ReadLine());                // 문자 입력 시 exception
    bool b = int.TryParse(Console.ReadLine(), out int n);   // 전환 가능 여부 반환  // 예외 처리 포함
    if (b == true)
    {
        Console.WriteLine(n);
        break;
    }
    Console.WriteLine("다시 입력하세요");
}
Console.WriteLine("END");
