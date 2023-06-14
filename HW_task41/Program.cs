//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Plus(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]> 0) count = count + 1;
    }
    Console.WriteLine($"положительных чисел: {count}");
}

int size = Prompt("введите размер массива М");
int [] array = new int [size];
int a = Prompt("введите число");

for (int i = 0; i < size-1; i++)
{
    array[i] = Prompt("введите число");
}

Plus(array);

