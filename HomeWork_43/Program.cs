// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
double x = -(b1 - b2) / (k1 - k2);  x = Math.Round(x, 2);
double y = k1 * x + b1;             y = Math.Round(y, 2);

 Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");


