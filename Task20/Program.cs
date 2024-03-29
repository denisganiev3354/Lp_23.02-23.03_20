﻿// AB = √(xb - xa)2 + (yb - ya)2

// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt(5);
// double d = 5.09987354;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yA: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

double leng = Distance (xA, yA, xB, yB);
Console.WriteLine($"Растояние между точкой А и В равно = {Math.Round(leng, 2, MidpointRounding.ToZero)}");

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}
