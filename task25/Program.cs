// поменять местами первую и последнюю строку массива

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

void ReplaceArr(int [,] matr)
{
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0,j];
        matr[0,j] = matr[matr.GetLength(0) - 1, j];
        matr[matr.GetLength(0) - 1, j] = temp;
    }
}

int m = Prompt("text rows");
int n = Prompt("text columns");

int [,] matrix = new int [m,n];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

ReplaceArr(matrix);
PrintArray(matrix);