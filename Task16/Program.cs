﻿// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите ПЕРВОЕ число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool squareBoth = SquareBoth(number1, number2); // Вызов метода
Console.WriteLine(squareBoth ? "Да" : "Нет");


bool SquareBoth(int num1, int num2) // Метод
{
    return num1*num1 == num2 || num2*num2 == num1;
}