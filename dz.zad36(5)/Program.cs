﻿// // Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumNotEvenIndexNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            result = result + array[i];
        } 
    }
    return result;
}

int arraySize = 4, arrayMinValue = -99, arrayMaxValue = 99;
int[] arr = CreateArrayRndInt(arraySize, arrayMinValue, arrayMaxValue); 
PrintArray(arr);
int count = SumNotEvenIndexNum(arr);
Console.WriteLine($" -> {count}");