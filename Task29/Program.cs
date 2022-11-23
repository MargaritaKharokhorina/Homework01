// Задача 29. Программа, которая задает массив из 8 элементов,
// заполненный псевдослучайными числами, и выводит их на экран.

int[] array = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

RandomArray(array);
PrintArray(array);


