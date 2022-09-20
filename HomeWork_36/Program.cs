// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите количество элементов массива: ");
int listNumbers = Convert.ToInt32(Console.ReadLine()); 

int GetOddSum(int listNumbers, int startValue, int endValue)
  {

  int[] randomNumbers = new int[listNumbers];
  int sumValue = 0;
  
    for (int i = 0; i < randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(startValue, endValue);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumValue = sumValue + randomNumbers[i];
      }
    }
    return sumValue;
    
  }

int randomNumbers =  GetOddSum(listNumbers, 1, 100);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {randomNumbers}");










