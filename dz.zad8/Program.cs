Console.WriteLine("Показать все четные числа");
Console.WriteLine("Введите число:");
string number = Console.ReadLine()!;
int x = int.Parse(number);
for (int y = 1; y <= x; y++)
      if (y % 2 == 0)
      Console.WriteLine("Четное число: " + y);
for (int y = -1; y >= x; y = y - 1)
      if (y % 2 == 0)
      Console.WriteLine("Четное число: " + y);
