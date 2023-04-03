// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк матрицы НОМЕР 1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов матрицы НОМЕР 1");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число строк матрицы НОМЕР 2");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов матрицы НОМЕР 2");
int d = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[a, b];
int[,] array2 = new int[c, d];
int[,] array3 = new int[a, d];

if (b == c)
{
    FillMatrix(array1);
    PrintArray(array1);
    Console.WriteLine();
    FillMatrix(array2);
    PrintArray(array2);
    Console.WriteLine();
    int[,] multiMatrix = MultiMatrix(array1, array2, array3);
    Console.WriteLine("Результирующая матрица:");
    PrintArray(multiMatrix);
}

else
{
    Console.WriteLine("ПРОВЕРЬТЕ ВВОД: Число столбцов матрицы НОМЕР 1 НЕ равняется числу строк матрицы НОМЕР 2");
}

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
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

int[,] MultiMatrix(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum = sum + arr1[i, k] * arr2[k, j];
                arr3[i,j] = sum;
            }
        }
    }
    return arr3;
}