class Program
{
    static void Main(string[] args)
    {
        //
        bool input = int.TryParse(Console.ReadLine(), out int result);
        if (result >= 90)
        {
            Console.WriteLine("success");
        }

        //
        int score = 88;
        char grade;
        if (score >= 90) grade = 'A';
        else if (score >= 80) grade = 'B';
        else if (score >= 70) grade = 'C';
        else if (score >= 60) grade = 'D';
        else grade = 'F';
        Console.WriteLine(grade);

        //
        int grade1 = 1;
        switch (grade1)
        {
            case 1: Console.WriteLine("Excellent"); break;
            case 2:
            case 3: Console.WriteLine("Great"); break;
            default: Console.WriteLine("Good"); break;
        }

        //
        int input1 = 0;
        while (input1 >= 0)
        {
            input1 = int.Parse(Console.ReadLine());
            if (input1 < 0)
            {
                break;
            }
        }

        //
        int sum = 0;
        for (int i = 0; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        //
        for (int i = 2; i <= 9; i++)
            for (int j = 1; j <= 9; j++)
                Console.WriteLine($"{i} * {j} = {i * j}");

        //
        for (int i = 1; i <= 10; i++)
        {
            if (i <= 5)
                Console.WriteLine(i);
        }

        //
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 1)
                continue;
            Console.WriteLine(i);
        }

        //
        // 입력
        int count = 0;

        // 연산
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 50 == 0)
                count++;
        }

        // 출력
        Console.WriteLine(count);

        string[] fruits = { "사과", "배", "포도" };
        for (int i = fruits.Length - 1; i >= 0; i--)
            Console.WriteLine(fruits[i]);
        foreach (var item in fruits)
            Console.WriteLine(item);

    }
}