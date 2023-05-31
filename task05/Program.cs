// программа выводит случайное число из отрезка 0-99
// и показывает наибольшую цифру числа

int num = new Random().Next(10, 100);
int a = num/10;
int b = num%10;

Console.WriteLine("Random number: " + num);

if (a > b)
{
    Console.WriteLine("max is: " + a);
}
else 
{
    Console.WriteLine("max is: " + b);
}