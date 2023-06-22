// вывод натур чисел от m до n

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void NaturNum(int minNum, int num)
{
    if (minNum <= num)
    {
        Console.Write($"{minNum} ");
        NaturNum(minNum+1, num);
    }
}

int minNumber = Prompt("text min number");
int number = Prompt("text max number");

NaturNum(minNumber, number);

