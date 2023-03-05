// Задача 10: 
// Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNum = SecondNum (number);

if (number > 99 && number < 1000)
{
    Console.WriteLine ($"Вторая цифра: {secondNum}");
}
else 
{
    Console.WriteLine("Введено недопустимое значение.");
}
int SecondNum (int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}

// "ЭТАЛОННОЕ РЕШЕНИЕ!!!"

// int Prompt(string messege)
// {
//     System.Console.Write(messege);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Введите трёхзначное число > ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
//     return;
// }
// Console.WriteLine($"Введенное число '{number}'");
// int secondRank = number /10 % 10;
// Console.WriteLine($"Вторая цифра '{secondRank}'");