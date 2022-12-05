// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int Numbers(int[] array)
{
int numbs = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) numbs++;
}
return numbs;
}

int numbs = Numbers(array);
Console.WriteLine($"Количество чисел больше ноля --> {numbs}");



