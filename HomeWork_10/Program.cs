// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// Укажем размер, куда войдет трехзначное число, т.е. сгенерируем от 100 до 1000.
void MySolution ()
{
int number = new Random().Next (100, 1000);

int result = (number % 100 - number % 10) / 10;


Console.WriteLine(number);
Console.WriteLine($"{result}");
}

MySolution ();
