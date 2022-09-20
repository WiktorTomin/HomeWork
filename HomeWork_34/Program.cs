// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[6]; // Заполняем массив положительными трехзначными числами. 
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
  } 

int EvenNumbers(int[] array) // Создаем переменную и заполняем ее количеством четных чисел. 
{
    int total = 0;
    for (int i = 0; i < array.Length; i++ )
  {
    if (array[i] % 2 == 0)
     {
       total++;
     }
  }
    return total;
}

int total = EvenNumbers(array);
Console.WriteLine($"Количество чётных чисел: {total}");









