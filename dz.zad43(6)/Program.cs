// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] FindXandY(double b1, double k1, double b2, double k2)
{
    double x = 0;
    x = -(b1 - b2) / (k1 - k2);
    x = Math.Round(x, 2);
    double y = 0;
    y = k1 * x + b1;
    y = Math.Round(y,2);
    double[] xy = {x,y};
    return xy;

}   

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write (array[i]);   // ^1 - последний элемент
    }
    Console.WriteLine("]");
}


Console.Write("Enter the k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());


FindXandY(b1,k1,b2,k2);
double[] xy = FindXandY(b1,k1,b2,k2);
PrintArrayDouble(xy);