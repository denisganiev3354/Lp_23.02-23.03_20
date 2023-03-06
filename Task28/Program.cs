// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int factorial = Factorial(number);
    Console.Write($"Произведение чисел от 1 до {number} = {factorial}.");
}
else
{
    Console.WriteLine("Введено неверное значение! ");
}

int Factorial(int num)
{
    int multiplication = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multiplication *= i;
        }
    }
    return multiplication;
}