int GetSecondDigit(int x)
{
    int desyatki = x / 10;
    int iskomoe = desyatki % 10;  
   // Console.WriteLine("Вторая цифра: " + iskomoe);
    x = iskomoe;
    return (x);
}

Console.WriteLine("Нахождение второй цифры трехзначного числа");
Console.WriteLine("Введите трехзначное число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x)){
   Console.WriteLine("Неверный ввод");
   Console.WriteLine("Введите трехзначное число:");
}

//GetSecondDigit(x);
Console.WriteLine("Вторая цифра: " + GetSecondDigit(x));
