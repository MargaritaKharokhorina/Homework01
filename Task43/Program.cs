// Задача 43. Программа, которая находит точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите через запятую значения b1, k1, b2, k2");
string[] tokens = Console.ReadLine()!.Split(',');
double b1 = int.Parse(tokens[0]);
double k1 = int.Parse(tokens[1]);
double b2 = int.Parse(tokens[2]);
double k2 = int.Parse(tokens[3]);
string text = tokens[0].Trim();

double X(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double Y(double b1, double k1)
{
    double x = X(b1, k1, b2, k2);
    double y = k1 * x + b1;
    return x;
}

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1);
x = Math.Round(x, 1);
y = Math.Round(y, 1);
Console.WriteLine($"Точка пересечения двух прямых --> ({x},{y})");

