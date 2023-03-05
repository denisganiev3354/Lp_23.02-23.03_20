// Задача 15: Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, и 
// 2.проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0  && number < 8)
{
    bool dayOfTheWeek = DayOfTheWeek(number);
    Console.WriteLine(dayOfTheWeek ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Нет такого дня недели. ");
}

bool DayOfTheWeek(int num)
{
    return num == 6 || num == 7;
}


// ЭТАЛОННОЕ РЕШЕНИЕ!!!

// int Prompt(string messege)
// {
//     System.Console.Write(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool IsWeekend(int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekday(int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели! ");

//     return false;
// }

// int weekDay = Prompt("Введите день недели > ");
// if (ValidateWeekday(weekDay))
// {
//     if(IsWeekend(weekDay))
//     {
//         Console.WriteLine("Наконец-то выходной!");
//     }
//     else
//     {
//         Console.WriteLine("Придется поработать!");
//     }
// }