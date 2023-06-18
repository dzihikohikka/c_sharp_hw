// поменять местами строки и столбцы

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

int [,] ReverseRC(int [,] matr)
{
    int [,] rtam = new int [matr.GetLength(1), matr.GetLength(0)];

    for (int i = 0; i < rtam.GetLength(0); i++)
    {
        for (int j = 0; j < rtam.GetLength(1); j++)
        {
        rtam[i,j] = matr[j,i];
        }
    }
    return rtam;
}

int m = Prompt("text rows");
int n = Prompt("text columns");

int [,] matrix = new int [m,n];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

ReverseRC(matrix);
PrintArray(ReverseRC(matrix));