while (true)
{
    Console.WriteLine("Enter input : ");
    string line= Console.ReadLine();
    if(line == "exit")
    {
        break;
    }

    Console.Write("You typed ");
    Console.WriteLine(line.Length);
    Console.WriteLine(" character(s)");
}