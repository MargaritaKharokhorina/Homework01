// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write($"{n} -> ");
while (count <= n)
{
    if (count == 2) {
        Console.Write($"{count}");
    } else if (count % 2 == 0)
    {
        Console.Write($", {count}");
    }
    count++;
}
Console.Write($"\n");