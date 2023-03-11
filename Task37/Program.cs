﻿// Задача 37: 
// 1. Найдите произведение пар чисел в одномерном массиве.
// 2. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Console.Write("Введите размер массива:");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arraySize];


// FillArray(array); 
// PrintArray(array);

// void FillArray(int[] arraySize)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arraySize.Length; i++)
//     {
//         arraySize[i] = rnd.Next(0, 100);
//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] Product(int[] arr)
// {
//     if(arr[i] % 1)
//     {

//     } 
//     int[] array = new int[arraySize];
//     for (int i = 0; i < arr.Length; i++)
//     {
        
//     }
// }


int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] newArray = Multiple(array);
PrintArray(newArray);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}


int[] Multiple(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0)
        newArr[size - 1] = arr[arr.Length / 2];
    return newArr;
}