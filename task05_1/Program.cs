// программа выводит случайное число из отрезка 0-99
// и показывает наибольшую цифру числа

void FindLargestDigit(int num){
int a = num/10;
int b = num%10;

Console.WriteLine("Random number: " + num); 

if (a > b)
{
    Console.WriteLine("max is: " + a);
}
else if (b > a)
{
    Console.WriteLine("max is: " + b);
}
else
{
    Console.WriteLine("numbers are equal");
}
}

int number = new Random().Next(10, 100);
int number1 = new Random().Next(1, 70);
int number2 = new Random().Next(-50, 25);
FindLargestDigit(number);
FindLargestDigit(number1);
FindLargestDigit(number2);