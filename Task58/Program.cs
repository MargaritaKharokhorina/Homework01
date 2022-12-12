// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

// Матрицу P можно умножить на матрицу K только в том случае, если 
// число столбцов матрицы P равняется числу строк матрицы K.
// Матрицы, для которых данное условие не выполняется, умножать нельзя.

int[,] MatrixA (int rows, int columns, int min, int max)
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

int [,] MatrixB (int rows, int columns, int min, int max)
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int [,] matrixMultiplication = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) Console.WriteLine("Умножение невозможно");
    
     for (int i = 0; i <  matrixMultiplication.GetLength(0); i++)
     {
        for (int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            matrixMultiplication[i, j] = 0;
        for (int k = 0; k < matrixMultiplication.GetLength(0); k++)
        {
            matrixMultiplication[i, j] += matrixA[i, k] * matrixB[k, j];
        }
        }
     }
     return matrixMultiplication;
}


int[,] matrixA = MatrixA(2, 2, 1, 5);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = MatrixB(2, 2, 1, 6);
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц: ");
int[,] matrixMultiplication = MatrixMultiplication(matrixA, matrixB);
PrintMatrix(matrixMultiplication);

