Console.WriteLine("이름을 입력하시오.");
string name = Console.ReadLine();
//Console.WriteLine($"이름은 {name}");
Console.WriteLine("이름은 {0}", name);

Console.WriteLine("숫자를 입력하세요.");
string inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);
Console.WriteLine(number);

Console.WriteLine("정수 두 개 입력하세요");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{number1} + {number2} = {number1 + number2}");