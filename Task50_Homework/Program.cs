// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите число строк матрицы");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов матрицы");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());

if (a > 0 && b > 0)
{
    int[,] array = new int[a, b];

    Console.WriteLine();
    Console.WriteLine("Изначальная матрица: ");
    // Console.WriteLine();
    FillMatrix(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Элемент по введенным индексам: ");
    // Console.WriteLine();
    CheckIndexMatrix(array);
    // PrintArray(array);
}
else Console.WriteLine("Некорректный ввод числа строк или столбцов");

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

void CheckIndexMatrix(int[,] arr)
{
    if (i < arr.GetLength(0) && j < arr.GetLength(1)) Console.WriteLine(arr[i, j]);
    else Console.WriteLine("Некорректный ввод индексов");
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