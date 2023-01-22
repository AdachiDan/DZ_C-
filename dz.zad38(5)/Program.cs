// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
        array[i] = Math.Round(array[i],1);
    }
    return array;
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

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double DiffMaxMin(double max, double min)
{
    double diff = max - min;
    diff = Math.Round(diff,2);
    return diff;
}

int arraySize = 4, arrayMinValue = 0, arrayMaxValue = 99;
double[] arr = CreateArrayRndDouble(arraySize, arrayMinValue, arrayMaxValue); 
PrintArrayDouble(arr);
double max = FindMax(arr);
double min = FindMin(arr);
double diff = DiffMaxMin(max, min);
Console.WriteLine($"Max -> {max}");
Console.WriteLine($"Min -> {min}");
Console.WriteLine($"Difference between Max & Min -> {diff}");