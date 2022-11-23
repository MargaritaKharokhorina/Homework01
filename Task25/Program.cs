// Задача 25. Цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите через запятую два числа A и B");
string[] tokens = Console.ReadLine()!.Split(',');
int a = int.Parse(tokens[0]);
int b = int.Parse(tokens[1]);
string text = tokens[0].Trim();

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = numA * result;
    }
    return result;
}
if (b > 0)
{
int exponentiation = Exponentiation(a, b);
Console.WriteLine($"{a} в степени {b} --> {exponentiation}");
}
else Console.WriteLine("Второе число должно быть натуральным");