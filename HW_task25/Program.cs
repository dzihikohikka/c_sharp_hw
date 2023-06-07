// а в степень б

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Step (int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result*x;
    }
    Console.Write(result);
}

int a = Prompt("text number a");
int b = Prompt("text step b");
Step(a, b);