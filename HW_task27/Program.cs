// сумма цифр в числе

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void DigitSum (int a)
{
    int sum = 0;
    int ost = 0;

    while (a > 0)
    {
        ost = a % 10; 
        a = a / 10;
        sum = sum + ost;
    }
    Console.WriteLine("summ of gigits: "+sum);
}

int number = Prompt("text a number");
DigitSum(number);