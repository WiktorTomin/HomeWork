// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1.Выполнить с помощью рекурсии.

string ShowNumber(int N)
{
    if( N == 1 )
    {
        return "1";
    }
    string result = N + " " + ShowNumber(N - 1);
    return result;
}

Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

string resultString = ShowNumber(N);
Console.WriteLine(resultString);




