// 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// 78 -> 8 
// 12-> 2 
// 85 -> 8

// Вариант 1, без метода

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstNum = number / 10;
// int secondNum = number % 10;
// if (firstNum > secondNum)
// {
//     Console.WriteLine($"Наибольшая цифра числа {firstNum}");
// }

// else
// {
//     Console.WriteLine($"Наибольшая цифра числа {secondNum}");
// }

// Вариант 2, с методом (тернарный оператор)

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstNum = number / 10;
// int secondNum = number % 10;

// int result = firstNum > secondNum ? firstNum : secondNum;
// Console.WriteLine($"Наибольшая цифра числа {result}");

// Создание метод

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");

int MaxDigit(int num)
{
    int firstNum = num / 10;
    int secondNum = num % 10;
    int result = firstNum > secondNum ? firstNum : secondNum;
    return result;
}