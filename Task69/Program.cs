// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



Console.Write("Введите первое  число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int exponentiationRec = ExponentiationRec(number1, number2);
Console.WriteLine();

if (number1 != 0 && number2 > 0)
{
    Console.WriteLine($"Число {number1} в степени {number2} = {exponentiationRec}");
}
else
{
    Console.WriteLine("Введено неверное значение!");
}

int ExponentiationRec(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return checked(num1 * ExponentiationRec(num1, num2 - 1));
}
