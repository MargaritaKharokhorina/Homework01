// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
if (num2 > num1)
{
    Console.WriteLine($"max = {num2}, min = {num1}");
}
if (num1 == num2)
{
    Console.WriteLine("Оба числа равны");
}
