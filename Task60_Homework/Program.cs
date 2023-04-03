// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите ширину матрицы");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите высоту матрицы");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину матрицы");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[a, b, c];

if (a <= 5 && b < 5 && c < 5)
{
    FillMatrix(array);
    PrintArray(array);
    Console.WriteLine();
}

else
{
    Console.WriteLine("Слишком большие значения параметров матрицы");
}

void FillMatrix(int[,,] matr)
{
    int value = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = value;
                value = value + 1;
            }
        }

    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}, ");
            }
        }
        Console.WriteLine();
    }
}