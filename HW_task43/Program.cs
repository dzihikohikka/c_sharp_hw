// программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Tochka(int a, int d, int a1, int d1)
{
    int x = 0;
    int y = 0;
    x = (a1 - a) / (d - d1);
    y = d * x + a;
    Console.WriteLine($"точка пересечения: x={x}, y={y}");
}

int k1 = Prompt("введите k1");
int b1 = Prompt("введите b1");
int k2 = Prompt("введите k2");
int b2 = Prompt("введите b2");

Tochka(b1, k1, b2, k2);