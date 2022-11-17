// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int date = Convert.ToInt32(Console.ReadLine());
if (date == 6 || date == 7)
{
    Console.WriteLine("Выходной день");
}
else if (date < 1 || date > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    Console.WriteLine("Не является выходным");
}