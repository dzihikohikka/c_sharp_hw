// найти расстояние между точками
int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int x1 = Prompt ("text x1: ");
int y1 = Prompt ("text y1: ");

int x2 = Prompt ("text x2: ");
int y2 = Prompt ("text y2: ");

void CalcDistance (int a, int b, int c, int d)
{
    double s = Math.Sqrt((a-b)*(a-b)+(c-d)*(c-d));
    Console.WriteLine("Distance is: "+s);
}
CalcDistance(x1, x2, y1, y2);

