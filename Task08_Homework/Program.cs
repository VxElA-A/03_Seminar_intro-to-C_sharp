﻿// Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = 2;
    while (count <= number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}

else
{
    Console.Write("Введен 0 или отрицательное число");
}