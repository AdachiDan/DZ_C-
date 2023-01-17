double Exponentiation(double number1, double number2)
{
    if (number2 > 0)
    {
        double result = number1;
        for (double i = 0; i < number2 - 1; i++)
        {
           result *= number1;
        }
        return result;
    }
    else
    {
        double result = number1;
        for (double i = 0; i > number2 + 1; i = i - 1)
        {
          result = result / number1;
        }
        return result;
    }
}


Console.WriteLine("Raising number 1 to power number 2");
Console.WriteLine("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double exp = Exponentiation(num1,num2);
Console.WriteLine($"-> {exp}");

