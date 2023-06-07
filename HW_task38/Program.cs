// из массива веществ чисел разницу между мин и макс

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

void DiffMinMax (int [] arr)
{
    int min = arr[0];
    int max = arr[0];
    int diff = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (min < arr[i])
        {
            min = arr[i];
        }
        if (max > arr[i])
        {
            max = arr[i];
        }
    }
    diff = max - min;
    if (diff < 0) diff = diff * -1;
    Console.WriteLine("difference is "+diff);
}

int l = Prompt("text lenght");
int mini = Prompt("text min number");
int maxi = Prompt("text max number");

Console.WriteLine();

int [] array = GetArray(l, mini, maxi);
PrintArray(array);

DiffMinMax(array);