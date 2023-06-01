// палиндром или нет?

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Check (int num)
{
    int input = num;
    int reverse = 0;
    int temp = 0;

    while (input > 0)
    {
        temp = input % 10;
        reverse = reverse * 10 + temp;
        input = input / 10;
    }

    if (reverse == num)
    {
        Console.WriteLine("yes is palindrom");
    }
    else
    {
        Console.WriteLine("No");
    }
}

int number = Prompt("text 5digit number: ");
Check(number);