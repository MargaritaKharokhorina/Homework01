// Задача 66. Задайте значения M и N. Напишите программу, которая найдет сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaDigits(m, n));

int SummaDigits(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numN + SummaDigits(numM, numN - 1);
    else return numN + SummaDigits(numM, numN + 1);
}
