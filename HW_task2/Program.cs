// из двух чисел макс и мин
Console.WriteLine("Text first number ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Text second number ");
int b = int.Parse(Console.ReadLine());

if ( a > b)
{
    Console.WriteLine("Max:" + a + " min:" + b);
}
else
{
    Console.WriteLine("Max:" + b + " min:" + a);
}
