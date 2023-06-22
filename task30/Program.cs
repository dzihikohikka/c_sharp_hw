// вывод суммы цифр числа

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int SumNum(int num)
{
    if (num == 0)
    {
        return 0;
    }
    
    return (num%10 +  SumNum(num / 10));
}

int number = Prompt("text number");
Console.WriteLine (SumNum(number));
