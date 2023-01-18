int InsertDigit(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number%10;
        number = number/10;
    }
    return result;
}

Console.WriteLine("Sum of digits program");
int insertNumber = InsertDigit("Enter the number");
int sumOfDigits = SumOfDigits(insertNumber);
Console.WriteLine($"The sum of digits is {sumOfDigits}");

