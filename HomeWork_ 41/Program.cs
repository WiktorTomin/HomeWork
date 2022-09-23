// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа (через пробел): ");

int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;
 
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        result = result + 1;
    }
}
 Console.WriteLine($"Количество положительных чисел: {result}");





