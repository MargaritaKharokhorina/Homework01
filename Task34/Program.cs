// Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество чeтных чисел в массиве.

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
         else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
Console.Write("Массив: ");
int[] arr = CreateArrayRndInt(4, 500, 850);
PrintArray(arr);

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int evenNumbers = EvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве --> {evenNumbers}");

