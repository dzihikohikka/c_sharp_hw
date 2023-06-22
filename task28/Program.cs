// рекурсия. вывод всех натур чисел до N

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void NaturNum(int num, int count)
{
    if (count <= num)
    {
        Console.Write($"{count} ");
        NaturNum(num, count+1);
    }
}
int number = Prompt("text a number");
int i = 1;
NaturNum(number, i);
