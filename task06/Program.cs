// из рандомного трехзнач удалить вторую цифру 578 - 58

int FindFirst(int num)
{
    int firstNum = num / 100;
    return firstNum;
}

int FindLast(int num)
{
    int lastNum = num % 10;
    return lastNum;
}

int number = new Random().Next(99, 1000);
Console.WriteLine("number is: " + number);
Console.WriteLine(FindFirst(number) + "" + FindLast(number));