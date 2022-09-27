//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[n, m];
Random result = new Random();
{
    for( int i = 0; i < n; i++)
    {
       for( int j = 0; j < m; j++)
       {
          array[i, j] =  result.NextDouble() * 10; 
          Console.Write( "{0,6:F2}", array[i, j]);
       } 
         Console.WriteLine();
    }
    
}














