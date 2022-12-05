// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
 }

 double[] Average(int[,] matrix)
{
    double[] AverageMean = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        AverageMean[j] = Math.Round(sum / matrix.GetLength(0), 1);
    }
    return AverageMean;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.WriteLine($"{arr[i]}; ");
        else Console.WriteLine($"{arr[i]}");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 5, 15);
PrintMatrix(array2D);
double[] array = Average(array2D);
Console.WriteLine("Среднее арифметическое элементов в столбцах:");
PrintArray(array);