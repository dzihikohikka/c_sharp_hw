// программа выводит случайное число из отрезка 0-99
// и показывает наибольшую цифру числа

int FindFirst(int num)
{
    int a = num/10;
    return a;
}

int FindSecond(int num)
{
    int b = num%10;
    return b;
}

void FindLargestDigit(int num, int a, int b){

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
int firstDigit = FindFirst(number);
int secondDigit = FindSecond(number);
FindLargestDigit(number, firstDigit, secondDigit);

