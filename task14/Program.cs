// вывод массива из 8 эл-тов заполненный 0 и 1 ( 1 1 0 0 1 0 1 0)

int [] array = new int [8];

for (int i = 0; i < 9; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]+", ");
}


