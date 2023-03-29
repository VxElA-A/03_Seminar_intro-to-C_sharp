// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double GetAverDouble(int[,] arr)
{
    double sum = 0;
    double aver = 0;
    double[] array1 = new double [b];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            while (j < arr.GetLength(1))
                sum = sum + arr[i, j];
                aver = sum / (j + 1);
        }
    }
    return aver;
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
// Console.WriteLine();
Console.WriteLine("Заполненная матрица: ");
Console.WriteLine();
FillMatrix(array);
PrintArray(array);
Console.WriteLine();
double getAverDouble = GetAverDouble(array);
Console.WriteLine(getAverDouble);