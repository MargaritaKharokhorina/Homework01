// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

ReturnSecondDigit(number);

void ReturnSecondDigit(int num)
{
if (num > 99 && num < 1000)
{
int result = num / 10 % 10;
Console.WriteLine("Выведена вторая цифра числа");
Console.WriteLine(($"Результат --> {result}"));
}

else Console.WriteLine("Ввели не трёхзначное число");
}
