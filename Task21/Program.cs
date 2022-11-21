// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату точки xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
   double xc = (xb - xa) * (xb - xa);
   double yc = (yb - ya) * (yb - ya);
   double zc = (zb - za) * (zb - za);
   double result = Math.Sqrt(xc + yc + zc);
   return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);

