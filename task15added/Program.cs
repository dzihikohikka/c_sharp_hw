// вывод чисел от 1 до 100, где все числа кратные 3 
// заменены на Fizz, кратные 5 Buzz 
// если и 3 и 5 то FizzBuzz


int [] array = new int[101];

for (int i = 1; i < 101; i++)
{
    array [i] = i;
    if (array [i]  % 15 == 0)
    {
        Console.Write("FizzBuzz, ");
    }
    else if (array [i] % 3 == 0)
    {
        Console.Write("Fizz, ");
    }
    else if (array [i] % 5 == 0)
    {
        Console.Write("Buzz, ");
    }
    else
    {
    Console.Write(array[i]+ ", ");
    }
}




