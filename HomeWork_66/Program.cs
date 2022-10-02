// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumNumbers(int M, int N)
{
    if(N == M)
    {
        return M;
    }
    int sum = N + GetSumNumbers(M, N - 1);
    return sum;
}

string ShowNumber(int M, int N)
{
    if( N == M )
    {
        return $"{M}";
    }
    string result = ShowNumber(M, N - 1) + " " + N ;

    return result;
} 

Console.WriteLine("Input number: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

string resultString = ShowNumber(M, N);
Console.WriteLine($"Числа от {M} до {N}: {resultString}");

int result = GetSumNumbers( M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} = {result}");

