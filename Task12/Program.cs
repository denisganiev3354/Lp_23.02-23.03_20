// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое чило: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int result = number % number1;
if(result == 0)
{
    Console.WriteLine($"Число {number}  кратно числу {number1}");
}
else
{
    Console.WriteLine($"Остаток от деления {result}");
}





// Console.WriteLine("Введите первое чило: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе чило: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(multiPlicitint ? "Не кратно" : $"Не кратно, отаток {multiplicitint}");

// bool multiPlicitint = MultiPlicitint(number, number1);
// int multiplicitint = Multiplicitint(number, number1);
// int Multiplicitint(int num, int num1)
// {
//     int result = num % num1;
//     return result;
// }


// bool MultiPlicitint(int num, int num1)
// {
//     return result = num % num1;
// }


