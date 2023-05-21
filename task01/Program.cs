// принимает 2 числа, проверка на первое квадрат второго

Console.WriteLine("text first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("text second number");
int b = int.Parse(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("Yes, " + a + " qwuare of " + b);
}
else 
{
    Console.WriteLine("No");
}