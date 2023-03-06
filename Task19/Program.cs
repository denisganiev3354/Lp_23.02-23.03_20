﻿// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool polyndrom = Polyndrom(number);

if (number > 10000 && number < 99999)
{
    Console.WriteLine(polyndrom ? "YES" : "NO");
}
else
{
    Console.WriteLine("ERROR!");
}

bool Polyndrom(int num)
{
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    if (num1 == num5 && num2 == num4)
    {
        return true;
    }
    return false;
}