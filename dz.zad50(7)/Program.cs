﻿// Напишите программу, кот на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нетю

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 - такого элемента в массиве нет.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}  |");
            else Console.Write($"{matrix[i, j], 5}  ");  
        }
        Console.WriteLine("]");
    }
}


int rows = 3, columns = 4, min = -100, max = 100;
int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(array2D);
Console.WriteLine("Enter i number: ");
int numi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter j number: ");
int numj = Convert.ToInt32(Console.ReadLine());
if ((numi - 1) > rows || (numj - 1) > columns) Console.WriteLine("Index was outside the bounds of the array");
else Console.WriteLine($"item [{numi}, {numj}] is {array2D[(numi - 1),(numj - 1)]}");

