// 2 числа на вход. второе кратно первому?
// если нет то остаток от деления
// 34, 5 - не кратно ост 4
// 16, 4 - кратно

void Ostatok(int num1, int num2)
{
    int ost = num1 % num2;
    Console.WriteLine(ost);
}

Console.WriteLine("Text first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Text second number");
int b = int.Parse(Console.ReadLine());

if ( a % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток: ");
    Ostatok(a, b);
}