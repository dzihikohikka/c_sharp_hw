// кубы до n

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void CubePrint (int a)
{
    int i = 0;
    while (i < a)
    {
      i = i+1;
      Console.Write(i*i*i+" ");
    }
}

int num = Prompt ("text number: ");
CubePrint(num);
