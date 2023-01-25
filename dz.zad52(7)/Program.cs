// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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

void AverageJ(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i,j];            
        }
        average /= matrix.GetLength(0);
        average = Math.Round(average,1);
        Console.Write($" {average}; ");
    }
    
}

int rows = 5, columns = 5, min = 0, max = 10;
int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(array2D);
AverageJ(array2D);