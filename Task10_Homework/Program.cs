// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

// Задаем сначала метод

int SecondDigit(int num) // Расположил метод выше всей программы
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - firstDigit * 100 - thirdDigit) / 10;
    return secondDigit;
}

// Основная программа:

Console.WriteLine("Введите трёхзначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Некорректный ввод");
}

else
{
int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра трёхзначного числа -> {secondDigit}");
}