// возведение числа в степень

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int Step(int first, int second, int count)
{
    if (count == second)
    {
        return 1;
    }

    return (first*Step(first,second, count +1));
}

int a = Prompt("text a");
int b = Prompt("text b");
int k = 0;

Console.WriteLine();
Console.Write(Step(a,b,k));
