// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
{
    for( int i = 0; i < n; i++)
    {
       for( int j = 0; j < m; j++)
       {
          array[i, j] = Convert.ToInt32(new Random().Next(0, 10)); 
       } 
       
    }

     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
       {
            Console.Write(array[i,j] + " ");  
       }
         Console.WriteLine();
    }
}

Console.WriteLine("Введите координаты");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

    if (x >= n && y >= m) 
     {
        Console.WriteLine($"Неверные данные!");
     }
    else 
     { 
         object z = array.GetValue(x, y);
         Console.WriteLine($"Значение в ячейке равно:{z} ");
     }






















