// 숫자, 문자, 문자열 출력하기
Console.WriteLine(100);         // int
Console.WriteLine(100 + 1);
Console.WriteLine('A');         // char
Console.WriteLine("Hello");     // string
Console.WriteLine("Level " + 7); // string   "Level 7"

// 특정 형식으로 출력하기
// {0}, {1}, {2} 와 같은 포맷 지정자(placeholder)   // printf
Console.WriteLine("{0} {1}", 1, 'A');
// 2 * 3 = 6
int a = 2;
int b = 3;
Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

int level = 12;
Console.WriteLine("Level " + level);
Console.WriteLine("Level {0}", level);

string name = "홍길동";
Console.WriteLine("{0}님 안녕하세요", name);

// 특수문자 출력하기 ( Escape 문자 ) '\문자'

// \ 출력
Console.WriteLine("\\");
Console.WriteLine("\"Hello World\"");

// file path (C:\...)
Console.WriteLine("C:\\Users\\admin");
Console.WriteLine(@"C:\Users\admin");       // escape 문자 상관 없이 전체가 문자열
// @ 약어 식별자

// $ 문자열 보간법
Console.WriteLine("{0} {1}", 10, 'B');
Console.WriteLine($"{10} {'B'}");
int c = 2;
int d = 3;
Console.WriteLine($"{c} * {d} = {c * d}");
