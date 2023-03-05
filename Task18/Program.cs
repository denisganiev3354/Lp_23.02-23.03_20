// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).




Console.WriteLine("Введите номер четверти ");
Console.Write("Четверть: ");
int quater = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(quater));

string Range(int num)
{
    if (num == 1) return "X > 0, y > 0";
    if (num == 2) return "X < 0, y > 0";
    if (num == 3) return "X < 0, y < 0";
    if (num == 4) return "X > 0, y < 0";
    return"Такой четверти не существует.";
}




// Console.WriteLine("Введите координаты точки ");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0 
//                         ? $"Указанные координаты соответствует четверти - {quarter}"
//                         : "Введены некорректные координаты";

// Console.WriteLine(result);
// int Quarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }
