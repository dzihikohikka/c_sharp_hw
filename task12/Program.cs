// на вход число - вывод кол-во цифр

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Digits(int b)
{
    int count = 0;
    while (b > 0)
    {
       b = b / 10;
       count++;
    }
    Console.WriteLine("digits is " + count);
}

int number = Prompt("text a number ");
Digits(number);