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


// извините, когда вчера отправила у меня не получилось вывести все числа
// а сегодня я нашла и исправила оштбку, в общем все выводит верно!
// и семинар тоже просмотрела, задачи решилаБ можете увидеть task23-24
// репозиторий открыт. Надеюсь когда-нибуть попаду на семинар, 
// очень хочется пошарить экран))

void ArifSredStolb (int [,] matr)
{
    int [] sum = new int [matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum [j] = matr[i,j]+ sum[j];
        }
        Console.Write($"{sum[j]/matr.GetLength(0)} "); 
    }   
}

int m = Prompt("text m:");
int n = Prompt("text n:");
int [,] matrix = new int [m,n];

Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

ArifSredStolb(matrix);
