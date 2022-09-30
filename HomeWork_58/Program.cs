// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.


Console.WriteLine("Введите размеры матриц:");
int a = InputNumbers("Введите число строк 1-й матрицы: ");
int b = InputNumbers("Введите число столбцов 1-й матрицы: ");
int c = InputNumbers("Введите число столбцов 2-й матрицы: ");
int size = InputNumbers("Введите числo: от 1 до ");

int[,] firstMatrix = new int[a, b];
CreateArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[b, c];
CreateArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMatrix);

int[,] exitMatrix = new int[a,c];

MultiMatrix(firstMatrix, secondMatrix, exitMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(exitMatrix);

void MultiMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] exitMatrix)
{
  for (int i = 0; i < exitMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < exitMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      exitMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string values)
{
  Console.Write(values);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(size);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}










