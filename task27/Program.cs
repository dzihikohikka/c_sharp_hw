// частота встречания из введенных данных

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

int [] GetFillFromKeyBoard (int len)
{
     int [] arr = new int [len];

     for (int i = 0; i < len; i++)
     {
        Console.Write("text element ");
        arr [i] = int.Parse(Console.ReadLine()!);
     }
     return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void Often (int [] arr)
{
    for ( int i = 0; i < arr.Length; i++)
    {
        int count = 1;
        int check = arr[i];
        for (int j = i+1; j < arr.Length; j++)
        {
            if ( check == arr[j]) 
            {
                count=count+1; 
                arr[j] = 0;
            }
        }
        if (arr[i]==0) Console.Write("");
        else
        {
        Console.WriteLine($"number {arr[i]} here {count} times");
        }
    }
}

int leng = Prompt("text a length");

int [] array = GetFillFromKeyBoard(leng);
PrintArray(array);

Console.WriteLine();
Often(array);