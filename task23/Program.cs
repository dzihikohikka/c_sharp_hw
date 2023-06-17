// записать массив где число задается по формуле i+j 
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i<matr.GetLength(0); i++)
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
    for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i+j;
        }
    }
}

int m = Prompt("text m");
int n = Prompt("text n");
int [,] matrix = new int [m,n];

FillArray(matrix);
PrintArray(matrix);