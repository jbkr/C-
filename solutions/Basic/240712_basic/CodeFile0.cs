using System;

// .Net 6 이후
// 최상위 문 사용 가능

Console.WriteLine("Hello, World!");

Func(10);

// 함수 선언, 클래스 선언은 아래쪽에
int Func(int x)
{ return x; }