// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinareCode(number));

string BinareCode(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}


// Console.WriteLine("Введите десятичное число: ");
// int num10 = Convert.ToInt32(Console.ReadLine());

// int num2 = ToBinary(num10);

// Console.WriteLine(num2);

// int ToBinary(int num)
// {
//     return num < 2 ? num % 2 : (num % 2) + 10 * ToBinary(num / 2);
// }




// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{number} -> {ToBinary(number)}.");


// int ToBinary(int numberValue)
// {
//     int binaryNumber = 0, buffer = numberValue, dec = 1;
//     while (buffer > 0)
//     {
//         binaryNumber = binaryNumber + buffer % 2 * dec;
//         dec *= 10;
//         buffer /= 2;
//     }
//     return binaryNumber;
// }