// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)

// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

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

int CalcDiagMatrix(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) sum = arr[i, j] + sum;
        }
    }
    return sum;
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
Console.WriteLine("Сумма главной диагонали: ");
Console.WriteLine();
int calcDiagMatrix = CalcDiagMatrix(array);
Console.WriteLine(calcDiagMatrix);
