// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

int[] RealNumberSize = new int[5];
  for (int i = 0; i < RealNumberSize.Length; i++ )
  {
    RealNumberSize[i] = new Random().Next(1, 100);
    Console.Write(RealNumberSize[i] + " ");
  }

int maxValue = RealNumberSize[0];
int minValue = RealNumberSize[0];

  for (int i = 1; i < RealNumberSize.Length; i++)
  {
    if (maxValue < RealNumberSize[i])
    {
      maxValue = RealNumberSize[i];
    }
    
    if (minValue > RealNumberSize[i])
    {
      minValue = RealNumberSize[i];
    }
  }

  int result = maxValue - minValue;

  Console.WriteLine($"Разность между ({maxValue}) и ({minValue}) элементами равна: {result}");






