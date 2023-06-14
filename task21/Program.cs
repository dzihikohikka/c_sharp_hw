// может ли существовать такой треугольник
// теорема о треугольнике каждая сторона меньше суммы двух других

int Prompt (string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void CheckTriang(int a, int b, int c)
{
    if ((a+b >c) && (a+c >b) && (b+c >a)) Console.Write("Yes");
    else Console.Write("NO");
}

int aa = Prompt("text a");
int bb = Prompt("text b");
int cc = Prompt("text c");

Console.WriteLine();

CheckTriang(aa, bb, cc);