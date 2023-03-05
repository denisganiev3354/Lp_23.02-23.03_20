// var num = Console.ReadLine();  
// Console.WriteLine(num.Count() < 3 ? "Третьей цифры нет" : num[2]);


// Задача 13: Напишите программу, которая 
// 1.выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdNum = ThirdNum(number);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет. ");
}
else
{
    Console.WriteLine($"Третья цифра: {thirdNum}");
}
int ThirdNum(int num)
{
    while (num > 999)
    {
         num = num / 10;
    }
    return num% 10;
}




// ЭТАЛОННОЕ РЕШЕНИЕ!!!

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;

// }

// bool ValiDateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет. ");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число > ");
// if (ValiDateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }