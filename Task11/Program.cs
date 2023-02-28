// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// 1.

// int maxDigit = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999  -> {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
 
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Рузультат -> {result}");


// 1.2

// // Console.Write(firstDigit);
// // Console.Write(thirdDigit);

// 2.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное  трехзначное число -> {number}");
int delSecondDigit = DelSecondDigit(number);
Console.WriteLine($"Полученное двухзначное число -> {delSecondDigit}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int delSecondD = firstDigit * 10 + lastDigit;
    return delSecondD;
}




