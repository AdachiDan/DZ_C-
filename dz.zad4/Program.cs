Console.WriteLine("Поиск наибольшего числа из трех");
Console.WriteLine("Введите первое число:");
string inputString = Console.ReadLine()!;
int x = int.Parse(inputString);

Console.WriteLine("Введите второе число:");
string inputString2 = Console.ReadLine()!;
int x2 = int.Parse(inputString2);

Console.WriteLine("Введите третье число:");
string inputString3 = Console.ReadLine()!;
int x3 = int.Parse(inputString3);

int max = x;
if (x2 > x)
   max = x2;
if (x3 > max)
   max = x3;
Console.WriteLine("Наибольшее из трех: " + max);
