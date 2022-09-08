// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// Так как в неделе 7 дней, то справедливо указать, что 7 день - выходной,
// иначе дни не выходные.

Console.Write("Введите число дня недели: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

void FindDayWeek (int weekDay)
 {
  if (weekDay == 7) 
    {
     Console.WriteLine("Это выходной день");
    }
  else
     Console.WriteLine("Это не выходной день");
 }

 FindDayWeek (weekDay);







