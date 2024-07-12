// 유니코드 출력 - 2 바이트 - char ( 2 bytes )
Console.WriteLine("\x41");      // 0 - 255
Console.WriteLine("\x0041");    // 2의 16제곱
Console.WriteLine("\u0041");
Console.WriteLine("A");

Console.WriteLine("\uAC00");
Console.WriteLine("가");
Console.WriteLine((char)44032);
Console.WriteLine((int)'가');    // 44032(십진수), 0xAC00(16진수)
Console.WriteLine((int)'힣');    // 55203

for (char a = '가'; a <= '힣'; a++)
{
    Console.Write(a);
}
// C보다 유연 ( 유니코드 기반 )