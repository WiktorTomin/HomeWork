// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

GetFunctionAkkerman(m,n);


void GetFunctionAkkerman(int m, int n)
{
    Console.Write(resultAkkerman(m, n)); 
}

int resultAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return resultAkkerman(m - 1, 1);
    }
    else
    {
        return (resultAkkerman(m - 1, resultAkkerman(m, n - 1)));
    }
}   Console.WriteLine();


















