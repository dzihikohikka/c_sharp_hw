// выдача строки с мин ++ элтов

int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

void MinSumOfStrokes(int [,] matr)
{
    int [] sum = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum [i] = matr[i,j]+sum[i];
        }
        Console.WriteLine(sum[i]);
    }
Console.WriteLine();

        int mini = 0;
        int minisum = sum [mini];
        for (int k = 0; k < sum.Length-1; k++)
        {

            if (minisum>sum[k+1])
            {
                minisum = sum[k+1];
                mini = k+1;
            }
        }
    Console.WriteLine($"stroke sum is {minisum} in {mini} stroke");
}


int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix = new int [m,n];

Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

MinSumOfStrokes(matrix);