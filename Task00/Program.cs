﻿// Напишите программу, которая на вход
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число
// умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32( Console.ReadLine());
int sqare = number * number;
Console.WriteLine ($"Квадрат числа {number} = {sqare}");
