Console.WriteLine("Проверка на четность");
Console.WriteLine("Введите число:");
string number = Console.ReadLine()!;
int x = int.Parse(number);

if (x % 2 == 0)
{
    Console.WriteLine("Число " + x + " четное");
}
else
{
    Console.WriteLine("Число " + x + " не является четным");
}
