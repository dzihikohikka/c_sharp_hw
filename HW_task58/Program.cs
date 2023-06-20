// перемножение матриц

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
// Ура! у меня все получилось, ошибка оказалась опечаткой и неправильный вывод готовой матрицы
// сам алгоритм был верныйб надеюсь новая версия у вас отобразится и я успела)
// с формулой очень сомневалась, но все проверила на онлайн калькуляторе для матриц, пришлось посидеть с листочком подумать)))
void ComposMatrix(int [,] matr1, int [,] matr2)
{
    if (matr1.GetLength(1)!=matr2.GetLength(0))
    {
        Console.WriteLine("we can't myltiply theese matrixs");
    }
    else
    {    
        int [,] mult = new int [matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < mult.GetLength(0); i++)
        {
            for (int j = 0; j < mult.GetLength(1); j++)
            {
                for (int n = 0; n < matr1.GetLength(0); n++)
                {
                mult[i,j] = matr1[i,n]*matr2[n,j]+mult[i,j];
                }
                Console.Write($"{mult[i,j]} ");
            }
        Console.WriteLine();
        }

    }
    
}

int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix1 = new int [m,n];

int m1 = Prompt("text m1:");
int n1 = Prompt("text n1:");
int [,] matrix2 = new int [m1,n1];

Console.WriteLine();

FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);


Console.WriteLine();

ComposMatrix(matrix1, matrix2);