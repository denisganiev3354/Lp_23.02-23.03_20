// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количесто чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
int[] array = new int[count];
int i = 0;
while (count < (M))
{
    Console.Write($"число № {count + 1}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) i++;
    count++;
}
Console.WriteLine($"{i} числа больше 0.");


