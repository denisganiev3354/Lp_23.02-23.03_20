// Задача 40: Напишите программу, которая 
// 1. принимает на вход три
// числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первую сторону ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a, b, c) ? "Да" : "Нет");

bool CheckTriangle(int numA, int numB, int numC)
{
   return numA < numB + numC && numB < numA + numC && numC < numA + numB;
}

