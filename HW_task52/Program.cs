// cреднее арифметич каждого СТОЛБЦА

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
            matr[i,j] = new Random().Next(0, 11);
        }
    }
}

void ArifSredStolb (int [,] matr)
{
    int [] sum = new int [matr.GetLength(0)];
    double Sred = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum [j] = matr[i,j]+ sum[j];
        }
        Console.WriteLine(sum[j]/matr.GetLength(0)); 
    }   
}

int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);
ArifSredStolb(matrix);
