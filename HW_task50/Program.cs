// массив m x n заполненный случайными веществ числами

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
            matr[i,j] = new Random().Next(-10, 11);
        }
    }
}

void FindElement(int [,] matr, int i, int j)
{
    if (i > matr.GetLength(0) || j> matr.GetLength(1)) 
    {
        Console.WriteLine("that element is not exist");
    }
    else Console.WriteLine($"Element i={i}, j={j} is {matr[i,j]}");
}

int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

int mFind = Prompt("text i");
int nFind = Prompt("text j");
FindElement(matrix, mFind, nFind);
