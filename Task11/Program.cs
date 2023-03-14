// 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого 
// числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Задаем сначала метод (по факту делал его после вывода случайного числа, потом перенес его выше)

int DoubleDigit(int num) // Расположил метод выше всей программы
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

// Основная программа:

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int doubleDigit = DoubleDigit(number);
Console.WriteLine($"Двузначное число от случайного трёхзначного числа -> {doubleDigit}");
