// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// Переведу число в строку, где  по списку, после второй цифры, будет выводиться третья цифра, 
// если она присутствует в числе.

Console.Write("Введите число: ");
int sizeNumber = Convert.ToInt32(Console.ReadLine());
string sizeNumberText = Convert.ToString(sizeNumber);

    if (sizeNumberText.Length > 2)
    {
        Console.WriteLine("Третья цифра числа: " + sizeNumberText[2]);
    }
    else 
    {
        Console.WriteLine("Отсутствует третья цифра числа");
    }



