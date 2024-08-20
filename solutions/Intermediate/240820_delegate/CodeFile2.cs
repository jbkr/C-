

class Program
{
    static void Main(string[] args)
    {
        Func<double> func = () => { return 1.0; };
        func();
        Func<int, int, int> func1 = (a, b) => a + b;
        func1(5, 3);
        Action<double> action = x =>
        {
            if (x > 3.14)
            {
                Console.WriteLine("bigger");
            }
            else
            {
                Console.WriteLine("smaller");
            }
        };
        action(5);
        Func<string, int> func2 = s => s.Length;
        Console.WriteLine(func2("Hello"));
        Func<int, int, int> func3 = (a, b) => a * b;
        func3(3, 5);
        Func<float, float, bool> func4 = (a, b) => a > 0 && b > 0;
        if (func4(3, 2))
        {
            Console.WriteLine("OK");
        }

        int[] ints = { 2, 3, 5, 6, 7 };
        Action<int[]> action1 = x =>
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        };
        action1(ints);

        Calculator calculator = new Calculator();
        calculator.Calculation(3, 5, '+', (a, b, c) =>
        {
            switch (c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
            }
        });

        Calc calc = new Calc(2, 3);
        calc.Fn((a, b) => a + b);

        int[] ints1 = { 2, 3, 5, 9, 10, 11, 12, 13 };
        Print((arr) =>
        {
            int sum = 0;
            foreach (int i in ints1)
            {
                sum += i;
            }
            return sum;
        }, ints);

    }

    static void Print(Func<int[], int> func, int[] array)
    {
        int sum = func(array);
        Console.WriteLine(sum);
    }
}

class Calculator
{
    int a;
    int b;
    char c;

    Action<int, int, char> func;

    public void Calculation(int a, int b, char c)
    {
        switch (c)
        {
            case '+':
                func = (a, b, '+')=>                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
        }
    }
}

class Calc
{
    int a = 0;
    int b = 0;                  // 두 숫자
    Func<int, int, int> fn;     // 연산방식
    public Calc() { }
    public Calc(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Fn(Func<int, int, int> fn)
    {
        Console.WriteLine(fn(a, b));
    }
}