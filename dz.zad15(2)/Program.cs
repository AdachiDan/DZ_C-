void Weekend(int x)
{
    if (SatSun(x))
    {
        Console.WriteLine("Выходной (Да)");
    }
    else
    {
       if(WorkDays(x))
       {
        Console.WriteLine("Не выходной (Нет)");
       }
       else
       {
        Console.WriteLine("Введите число от 1 до 7!");
       }
        
    }

}

bool SatSun(int x)
{
    return x == 6 || x == 7;
}

bool WorkDays(int x)
{
    return (0<x)&&(x<6);
}

Console.WriteLine("Проверка на выходной");
Console.WriteLine("Введите число от 1 до 7:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число от 1 до 7:");
}

Weekend(x);
