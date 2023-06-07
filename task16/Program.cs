// массив из 12 элтов с -9 до 9б. найти сумму + и - чисел

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
    {
        res[i] = new Random().Next(minVal, maxVal+1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i =0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]}, ");
    }
}

void Sum (int [] arr1)
{
    int sumPlus = 0;
    int sumNeg = 0;

    foreach(int elem in arr1)
    {
        if (elem > 0)
        {
            sumPlus = sumPlus + elem;
        }
        else
        {
            sumNeg +=elem;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"сумма положит = {sumPlus}, сумма отриц = {sumNeg}");
}



int l = Prompt("text lenght");
int [] array = GetArray(l, -9, 9);
PrintArray(array);
Sum(array);