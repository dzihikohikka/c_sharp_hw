// сумма натур от n до m

// вывод натур чисел от m до n

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int NaturSum(int minNum, int num)
{
    if (minNum == num+1)
    {
        return 0;
    }
    
    return (minNum+NaturSum(minNum+1, num));
}

int minNumber = Prompt("text min number");
int number = Prompt("text max number");

Console.Write(NaturSum(minNumber, number));

