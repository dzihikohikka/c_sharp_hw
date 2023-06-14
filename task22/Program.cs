// перевод числа в двоичную систему

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void ZeroOne(int num)
{
    int ost = -1;
    int count = 0;
    int num1 = num;
    while (num1 > 0)
    {
        num1 = num1 /2;
        count = count + 1;
    }

    int [] arr = new int [count];
    for (int i = 0; i < count; i++)
    {
        ost = num % 2;
        num = num / 2;
        arr [i] = ost;
        Console.Write(arr[i]);
    }
    Console.WriteLine();
    for (int i = count -1; i >= 0; i--)
    {
        Console.Write(arr[i]);
    }
    }

int number = Prompt("text number");
ZeroOne(number);