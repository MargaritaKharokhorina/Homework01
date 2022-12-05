// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите через запятую позицию строки и позицию столбца элемента");
string[] tokens = Console.ReadLine()!.Split(',');
int row = int.Parse(tokens[0]);
int column = int.Parse(tokens[1]);
string text = tokens[0].Trim();

if (row < 0 && column < 0) Console.WriteLine("Отрицательного индекса быть не может, перезадайте значения");

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
 
 void FindElementmatrix(int[,] matrix)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
        Console.WriteLine($"Элемент --> {matrix[row, column]}");
    else
        Console.WriteLine($"{row}, {column} --> такой элемент в массиве отсутствует");
}

 
 
 int[,] array2D = CreateMatrixRndInt(3, 4, 10, 100);
 PrintMatrix(array2D);
 FindElementmatrix(array2D);
