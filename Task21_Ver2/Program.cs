// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки А через запятую - xa,ya,za, затем координаты точки B - xb,yb,zb");
string[] tokens = Console.ReadLine()!.Split(',');
int xa = int.Parse(tokens[0]);
int ya = int.Parse(tokens[1]);
int za = int.Parse(tokens[2]);
int xb = int.Parse(tokens[3]);
int yb = int.Parse(tokens[4]);
int zb = int.Parse(tokens[5]);
string text = tokens[0].Trim();

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