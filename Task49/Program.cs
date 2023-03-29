// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные, 
// и замените эти элементы на их квадраты.

// Например изначально массив выглядит так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть так:
//  1 4 49 2
//  5 9  2 3
// 64 4  4 4

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

void ChangeMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
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
Console.WriteLine("Изначальная матрица: ");
Console.WriteLine();
FillMatrix(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новая матрица: ");
Console.WriteLine();
ChangeMatrix(array);
PrintArray(array);


