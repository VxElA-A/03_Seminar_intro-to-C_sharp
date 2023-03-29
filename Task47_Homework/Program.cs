// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5   7   -2  -0,2
// 1   -3,3   8  -9,9
// 8   7,8   -7,1   9

double[,] CreateMatrixRndDoub(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 5} ");
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine("Введите число строк матрицы");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов матрицы");
int b = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[a, b, -9, 10];

Console.WriteLine();
Console.WriteLine("Пустая матрица: ");
Console.WriteLine();
// PrintArray(array);
Console.WriteLine();
Console.WriteLine("Заполненная матрица: ");
Console.WriteLine();
double[,] array = CreateMatrixRndDoub(a, b, -9, 10);
PrintArray(array);