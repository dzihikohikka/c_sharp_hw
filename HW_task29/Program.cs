// массив из 8 чисел

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintArr (int a)
{
    int [] array = new int [a];

    for (int i = 0; i <= a; i++)
    {
    array[i] = new Random().Next(0,100);
    Console.Write(array[i]+", ");
    }
}

int len = Prompt("text a letgh");
PrintArr(len);