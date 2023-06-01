// определить четверть точки по х у 

int a = Prompt("text x: ");
int b = Prompt("text y: ");
FindCoordinate(a, b);

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCoordinate(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("first");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("second");
    }
        if (x < 0 && y < 0)
    {
        Console.WriteLine("third");
    }
        if (x > 0 && y < 0)
    {
        Console.WriteLine("forth");
    }
}