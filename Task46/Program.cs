// Задача 46: Задайте двумерный массив размеров m x n,
// заполненный случайными целыми числами.
//
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void FillMatrix(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
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

Console.WriteLine();
Console.WriteLine("Пустая матрица: ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Заполненная матрица: ");
Console.WriteLine();
FillMatrix(array);
PrintArray(array);
// PrintMatrix(array);




// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
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

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);

//--------------------------

// еще один вариант массива, но уже с мин/максом в генераторе (и + созданием нового массиа в методе):

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// ----------------------
// красивы вывод матрицы с регулировкой отступа (которую возможно тоже можно в будущем потом задать):

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 5} ");
//         }
//         Console.WriteLine("   |");
//     }
// }