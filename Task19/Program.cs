// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10000 && number < 100000)
{
bool PalindromeNumber()
{
    int num1 = number % 10;
    int num2 = number % 100 / 10;
    int num4 = number % 10000 / 1000;
    int num5 = number / 10000;

    return (num1 == num5 && num2 == num4);
}
Console.WriteLine(PalindromeNumber() ? "Число является палиндромом" : "Не является палиндромом");
}
else 
{
    Console.WriteLine("Ввели не пятизначное число");
}
