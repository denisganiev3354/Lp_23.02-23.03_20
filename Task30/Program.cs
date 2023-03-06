// int[] array = new int[8];
// array[4] = 215;
// int arrNum = array[i] 
// for(int i = 0; i < array.Lenght; i++)
// {
//     array[i] =
// } 


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];


// PrintArray(array);
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] mas = Mass(a);
Print(mas);

int[] Mass(int n)
{
    Random rand = new Random();
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}

void Print(int[] array11)
{
    for (int i = 0; i < array11.Length; i++)
    {
        Console.Write(array11[i] + " ");
    }
    return;
}