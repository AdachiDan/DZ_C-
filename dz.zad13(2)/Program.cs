void FindDigit(int x)
{
    int digit = x;
    int y = 100;
    while (digit > 0)
    {
        if (digit < y)
        {
            Console.WriteLine("Третьей цифры нет");
            break;
        }
        else
        {
            y = y * 10;
            if (digit < y)
            {
                int thirdDigit = digit % 10;
                Console.WriteLine("Третья цифра: " + thirdDigit);
                break;
            }
            else
            {
                y = y * 10;
                if (digit < y)
                {
                    digit = digit / 10;
                    int thirdDigit = digit % 10;
                    Console.WriteLine("Третья цифра: " + thirdDigit);
                    break;
                }
                else
                {
                    y = y * 10;
                    if (digit < y)
                    {
                        digit = digit / 100;
                        int thirdDigit = digit % 10;
                        Console.WriteLine("Третья цифра: " + thirdDigit);
                        break;
                    }
                    else
                    {
                        y = y * 10;
                        if (digit < y)
                        {
                            digit = digit / 1000;
                            int thirdDigit = digit % 10;
                            Console.WriteLine("Третья цифра: " + thirdDigit);
                            break;
                        }
                        else
                        {
                             y = y * 10;
                             if (digit < y)
                             {
                               digit = digit / 10000;
                               int thirdDigit = digit % 10;
                               Console.WriteLine("Третья цифра: " + thirdDigit);
                               break;
                             }
                        }    
                    }
                }
            }
        }
    }
}

Console.WriteLine("Нахождение третьей цифры числа");
Console.WriteLine("Введите число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число:");
}

FindDigit(x);



