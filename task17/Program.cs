// заменить все + на - и все - на +

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
        arr [i] = new Random().Next(minVal, maxVal+1);
    }
    return arr;
} 

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

void Change (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
         arr [i] = arr [i] * -1;
    }
}

int l = Prompt("text a lenght");
int mini = Prompt("text min num");
int maxi = Prompt("text max num");

int [] array = GetArray(l, mini, maxi);
PrintArray(array);
Console.WriteLine();
Change(array);
PrintArray(array);