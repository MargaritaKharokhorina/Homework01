// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeNumber (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} --> {i * i * i}");
    }
}
CubeNumber(number);
