// переворачиваем массив 12345 - 54321

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int [] GetArray(int size, int minVal, int maxVal)
{
    int []arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr [i] = new Random().Next(minVal, maxVal+1);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");
    }
}

void Reverse (int [] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr [arr.Length-1-i];
        arr [arr.Length-1-i] = temp;
    }
}

int l = Prompt("text lenght");
int mini = Prompt("text min number");
int maxi = Prompt("text max number");

Console.WriteLine();

int [] array = GetArray(l, mini, maxi);
PrintArray(array);
Console.WriteLine();
Reverse(array);
PrintArray(array);