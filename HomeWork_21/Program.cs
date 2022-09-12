// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    // Ввод переменной для выражения значения в представленной формуле(result).
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
   
    return result;
}

Console.Write("Input x1: ");
int x1 = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Input y1: ");
int y1 = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Input z1: ");
int z1 = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Input x2: ");
int x2 = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Input y2: ");
int y2 = (Convert.ToInt32(Console.ReadLine()));

Console.Write("Input z2: ");
int z2 = (Convert.ToInt32(Console.ReadLine()));

// Расстояние между двумя точками (c округлением до двух знаков после запятой).
double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance = {Math.Round(distance, 2, MidpointRounding.ToNegativeInfinity)}");

    







