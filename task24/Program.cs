// заменить все эл ты с двумя четными индексами на квадрат числа

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

int [,] GetArray(int m, int n, int maxVal, int minVal)
{
    int [,] result = new int [m ,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minVal,maxVal+1);
        }
    }
    return result;
}

void ChangeDou(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i,j] = matr[i,j]*matr[i,j];
            }
        }
    }
}

int rows = Prompt("введите строки");
int colums = Prompt("введите столбцы");

int max = Prompt("введите макс число");
int min = Prompt("введите миним число");

int [,] matrix = GetArray(rows, colums, max, min);
PrintArray(matrix);

ChangeDou(matrix);

Console.WriteLine();

PrintArray(matrix);