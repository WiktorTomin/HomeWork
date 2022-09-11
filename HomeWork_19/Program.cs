// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int arr = number.Length;

if (arr == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это число палиндром");
    }
    else 
    {
        Console.WriteLine($"{number} - это число не палиндром");
    }
}
else
{
    Console.Write($"{number} - не пятизначное число");
}
