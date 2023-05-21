// масимальное из трех чисел
Console.WriteLine("Text three numbers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if ( max < b)
{
    max = b;
}
else if ( max < c)
{
    max = c;
}
if (max < c)
{
    max = c;
    Console.WriteLine("max: " + max);
}
else
{
    Console.WriteLine("max: " + max);
}