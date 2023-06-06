// принимает число - вывод произведение чисел до него

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Compos(int num)
{
    int C = 1;

    for (int i = 1; i <= num; i++)
    {
        C = C * i;
    }
    Console.WriteLine("composition = " + C);
}

int number = Prompt("text number");
Compos(number);