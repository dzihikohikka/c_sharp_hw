// массив из случайных трехзначных чисел. найти количество четных

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int [] GetArray (int size, int minVal, int maxVal)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr [i] = new Random().Next(minVal,maxVal+1);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

void EvenCount (int [] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count = count +1;
        }
    }
    Console.WriteLine("таких чисел в массиве " + count);
}

int l = Prompt("text a length");
int mini = Prompt("text min num");
int maxi = Prompt("text max num");
int [] array = GetArray(l, mini, maxi);

Console.WriteLine();

PrintArray(array);
EvenCount(array);