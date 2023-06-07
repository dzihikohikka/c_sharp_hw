// найти число в массиве

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

int Find (int findNum, int [] arr)
{
    int yes = -1;
    foreach (int el in arr)
    {
        if(el == findNum) 
        {
            yes = 1;
            break;
        }
        else
        {
            yes = 0;
        }
    }
    return yes;
}

void TrueFalse(int b)
{
    if (b == 1)
    {
        Console.WriteLine("yes it here");
    }
    else if (b == 0)
    {
        Console.WriteLine("no");
    }
}

int l = Prompt("text lenght");
int mini = Prompt("text min number");
int maxi = Prompt("text max number");

int f = Prompt("text finding number");

Console.WriteLine();

int [] array = GetArray(l, mini, maxi);
PrintArray(array);

TrueFalse(Find(f, array));