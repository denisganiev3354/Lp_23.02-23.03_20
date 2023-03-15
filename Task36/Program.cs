// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Hайдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
PrintArray(array);

void FillArray(int[] arraySize)
{
    Random rnd = new Random();
    for (int i = 0; i < arraySize.Length; i++)
    {
        arraySize[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] SumElemOdd(int[] arr);
{
    int sum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       
    }
    return sum;
}