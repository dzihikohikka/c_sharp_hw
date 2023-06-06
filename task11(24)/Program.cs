// принимаем число а - выдаем сумму чисел до а

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Sum(int num)
{
    int S = 0;

    for (int i = 1; i <= num; i++)
    {
        S = S + i;
    }
    Console.WriteLine("sum = " + S);
}

int number = Prompt("text number");
Sum(number);