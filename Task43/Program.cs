// Задача 43: Напишите программу, которая.
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double X = 0;
double searchX = SearchX(X);

double YOne = 0;
double searchYOne = SearchYOne(YOne);

double YTwo = 0;
double searchYTwo = SearchYTwo(YTwo);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({searchYOne}; {searchYTwo})");


double SearchX(double x)
{
    x = Math.Round((b2 - b1) / (k1 - k2), 1);
    return x;
}

double SearchYOne(double y1)
{
    y1 = Math.Round((k1 * searchX + b1), 1);
    return y1;
}

double SearchYTwo(double y2)
{
    y2 = Math.Round((k2 * searchX + b2), 1);
    return y2;
}



