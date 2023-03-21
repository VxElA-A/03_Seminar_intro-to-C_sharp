// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Console.Write("Введите количество строк: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[lines, columns];
// FillMatrix(matrix);
// PrintMatrix(matrix);
// ChangeLines(matrix);
// PrintMatrix(matrix);

// int[,] FillMatrix(int[,] mtrx)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             mtrx[i, j] = rnd.Next(0, 10);
//         }
//     }
//     return mtrx;
// }

// void ChangeLines(int[,] mtrx)
// {
//     int firstLine = 0, lastLine = mtrx.GetLength(0) - 1;
//     for (int i = 0; i < mtrx.GetLength(1); i++)
//     {
//         int buffer = mtrx[firstLine, i];
//         mtrx[firstLine, i] = mtrx[lastLine, i];
//         mtrx[lastLine, i] = buffer;
//     }
// }

// void PrintMatrix(int[,] mtrx)
// {
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             Console.Write($"[{i},{j}]:{mtrx[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
ChangeLines(matrix);
PrintMatrix(matrix);

int[,] FillMatrix(int[,] mtrx)
{
    Random rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(0, 10);
        }
    }
    return mtrx;
}

void ChangeLines(int[,] mtrx)
{
    int firstLine = 0, lastLine = mtrx.GetLength(0) - 1;
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        int buffer = mtrx[firstLine, i];
        mtrx[firstLine, i] = mtrx[lastLine, i];
        mtrx[lastLine, i] = buffer;
    }
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"[{i},{j}]:{mtrx[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}