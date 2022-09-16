// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// Подсчет суммы цифр в числе.

int SumDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
     return sum;
}

Console.Write("Input number: ");
int mynumb = int.Parse(Console.ReadLine());

int result = SumDigits(mynumb);
Console.WriteLine(result);


