// из массива случайных элтов найти сумму всех четных позиций

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

void EvenPosSum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i= i + 2)
    {
         sum = sum + arr[i];
    }
    Console.WriteLine("sum even pos = "+ sum);
}

int l = Prompt("text a length");
int mini = Prompt("text min num");
int maxi = Prompt("text max num");
int [] array = GetArray(l, mini, maxi);

Console.WriteLine();

PrintArray(array);
EvenPosSum(array);