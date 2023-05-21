// Вывод диапащона всех целых чисел до этого
Console.WriteLine("Text a number");
int a = int.Parse(Console.ReadLine());
int b = a * -1;
int temp;

if (a < 0)
{
    temp = a;
    a = b;
    b = temp;
}
while (b <= a)
{
    Console.Write(b + " ");
    b += 1;
}