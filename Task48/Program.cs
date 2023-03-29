// Задача 48: Задайте двумерный массивразмера m на n,
// каждый элемент в массиве находится по формуле: Amn = m + n.
// Выведите полученный масси на экран.

// m = 3; n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] CreateMatrixRndInt(int m, int n)
// {
//     int[,] matr = new int[m, n];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i + j;
//         }
//     }
//     return matr;
// }

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число строк матрицы");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов матрицы");
// int b = Convert.ToInt32(Console.ReadLine());

// // int[,] array = new int[a, b];

// // Console.WriteLine();
// // Console.WriteLine("Пустая матрица: ");
// // Console.WriteLine();
// // // PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Заполненная матрица: ");
// Console.WriteLine();
// int[,] matrix = CreateMatrixRndInt(a, b);
// Console.WriteLine(matrix);

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк матрицы");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов матрицы");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

// Console.WriteLine();
// Console.WriteLine("Пустая матрица: ");
// Console.WriteLine();
// PrintArray(array);
Console.WriteLine();
Console.WriteLine("Заполненная матрица: ");
Console.WriteLine();
FillMatrix(array);
PrintArray(array);
