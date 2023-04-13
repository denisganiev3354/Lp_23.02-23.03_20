// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

<<<<<<< HEAD
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Cуммa натуральных элементов в промежутке от M до N = {SumNumbers(m, n)}");

int SumNumbers(int a, int b)
{
    if (a == 0) return (b * (b + 1)) / 2;            
    else if (b == 0) return (a * (a + 1)) / 2;       
    else if (a == b) return a;                       
    else if (a < b) return b + SumNumbers(a, b - 1); 
    else return b + SumNumbers(a, b + 1);  
}


  
=======
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int 
>>>>>>> 2dfdeae395cf9b2ad24d58f7bcd0bb7a6ad6aea2
