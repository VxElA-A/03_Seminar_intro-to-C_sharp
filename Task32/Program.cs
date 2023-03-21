﻿// Задача 32: Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void InverceArrayRndInt(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);
InverceArrayRndInt(array);
PrintArray(array);



// void FillArray(int[] arr)
// {
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(-10, 10);
//     }
// }

// void PrintArray (int [] arr)
// {
//     Console.Write ("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
//       else Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine ("]");
// }

// void InverseArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
// }

// int[] array = new int [5];
// FillArray(array);
// PrintArray(array);
// InverseArray(array);
// PrintArray(array);

