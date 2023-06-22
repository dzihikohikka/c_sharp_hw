// вывод натур чисел от n до 1

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void NaturNum(int num)
{
    if (num > 0)
    {
        Console.Write($"{num} ");
        NaturNum(num-1);
    }
}

int number = Prompt("text number");

NaturNum(number);

