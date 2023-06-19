// упорядочить эты массива в строках по убыванию

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
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}

void SortStroke (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < matr.GetLength(1); k++)
            {
                int temp = 0;
                if (matr[i,j]<matr[i,k]) 
                {
                    temp = matr[i,j];
                    matr[i,j] = matr[i,k];
                    matr[i,k] = temp;
                }
            }
        }
    }
}

int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix = new int [m,n];

Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

SortStroke(matrix);
PrintArray(matrix);