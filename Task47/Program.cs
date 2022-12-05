// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

 double[,] CreateMatrixRndDouble (int rows, int columns, double min, double max)
 {
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }
    return matrix;
 }

 void PrintMatrix(double[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 6}, ");
            else Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine("|");
    }
 }
 double[,] array2D = CreateMatrixRndDouble(3, 4, -1, 5.5);
 PrintMatrix(array2D);
