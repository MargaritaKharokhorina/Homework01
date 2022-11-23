// Задача 27. Программа, которая принимает на вход число 
// и выдает сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
if (number < 0) number = - number;
int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} ---> {sumDigits}");
