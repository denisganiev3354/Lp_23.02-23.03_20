﻿// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10 - 99 -> {number}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num) //num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}