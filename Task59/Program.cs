// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintArray2D(matrix);
Console.WriteLine();
int[] minElemIndexes = MinElemIndexes(matrix);
int[,] newMatrix = DeliteMinRowColumns(matrix, minElemIndexes[0],minElemIndexes[1]);
PrintArray2D(newMatrix);

int[,] DeliteMinRowColumns(int[,] arr2d, int rowDel, int columnsDel)
{
    int[,] newArray2d = new int[arr2d.GetLength(0) - 1, arr2d.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newArray2d.GetLength(0); i++)
    {
        if (m == rowDel) m++;
            for (int j = 0; j < newArray2d.GetLength(1); j++)
        {
            if (n == columnsDel) n++;
                newArray2d[i, j] = arr2d[m, n];
            n++;
        }
        n = 0;
        m++;
    }return newArray2d;
}

int[] MinElemIndexes(int[,] arr2d)
{
    int row = 0, columns = 0;
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            if (arr2d[i, j] < arr2d[row, columns])
            {
                row = i;
                columns = j;
            }
        }
    }
       return new int[] { row, columns };
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] arr2D = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}

void PrintArray2D(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j],5} ");
        }
        Console.WriteLine("|");
    }

}

/////////////////////////////////////////////////////


// int[,] matrix = CreateMatrixRndInt (4, 4, 1, 10);
// PrintArray2D (matrix);
// Console.WriteLine();
// int[]minElemIndexes = MinElemIndexes (matrix);
// int[,] newMatrix = DeleteMinRowColumn (matrix, minElemIndexes[0], minElemIndexes[1]);
// PrintArray2D (newMatrix);


// int[,] DeleteMinRowColumn (int[,] arr2D, int rowDel, int columnDel)
// {
//     int[,] newArray2D = new int[arr2D.GetLength(0)-1,arr2D.GetLength(1)-1];
//     int m = 0, n = 0;
//     for (int i = 0; i < newArray2D.GetLength(0); i++)
//     {
//         if (m == rowDel) m++; 
//         for (int j = 0; j < newArray2D.GetLength(1); j++)
//         {
//             if (n==columnDel) n++;
//             newArray2D[i, j] = arr2D[m, n];
//             n++;
//         }
//         n = 0;
//         m++;
//     }
//     return newArray2D;
// }


// int[] MinElemIndexes(int[,] arr2D)
// {
//     int row = 0, column = 0;
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//           if (arr2D[i, j] < arr2D[row, column])
//           {
//             row = i;
//             column = j;
//           }
//         }
//     }
//     return new int[]{row, column};
// }

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] arr2D = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             arr2D[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return arr2D;
// }

// void PrintArray2D(int[,] arr2D)
// {
//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             Console.Write($"{arr2D[i, j],5} ");
//         }
//         Console.WriteLine("|");
//     }

// }


// https://studwork.ru/spravochnik/matematika/matricy/umnojenie-matric

// int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth]; // 0, 1

//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }
//         }
//     }
//     return matrix;
// }