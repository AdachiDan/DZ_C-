// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}  |");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

void MultiplyMatrix(int[,] fstMartrix, int[,] secMartrix, int[,] resMatrix)
{
  for (int i = 0; i < resMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < fstMartrix.GetLength(1); k++)
      {
        sum += fstMartrix[i,k] * secMartrix[k,j];
      }
      resMatrix[i,j] = sum;
    }
  }
}

int rows = 2, columns = 2, min = 0, max = 10;
int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(array2D);
Console.WriteLine();
int rows2 = 2, columns2 = 2, min2 = 0, max2 = 10;
int[,] array2D2 = CreateMatrixRndInt(rows2, columns2, min2, max2);
PrintMatrix(array2D2);

int[,] resMatrix = new int[rows,columns2];
MultiplyMatrix(array2D, array2D2, resMatrix);
Console.WriteLine("Product of the first and second matrices: ");
PrintMatrix(resMatrix);