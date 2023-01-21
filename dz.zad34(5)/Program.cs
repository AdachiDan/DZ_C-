// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write (array[i]);   // ^1 - последний элемент
    }
    Console.WriteLine("]");
}

int CountEvenNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result = result + 1;
        } 
    }
    return result;
}

int arraySize = 4, arrayMinValue = 100, arrayMaxValue = 999;
int[] arr = CreateArrayRndInt(arraySize, arrayMinValue, arrayMaxValue); 
PrintArray(arr);
int count = CountEvenNum(arr);
Console.WriteLine($" -> {count}");
