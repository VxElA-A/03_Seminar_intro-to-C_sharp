// Задача 27: Напишите программу, которая принимает на
// вход число и выдает сумму цифр в числе

// 452 -> 11
// 82 -> 10
// 9012-> 12

Console.WriteLine("Введите целое положительное число: "); // Приглашение к вводу числа
int number = Convert.ToInt32(Console.ReadLine()); // Прием пятизначного числа

if (number <= 0) // Проверка условия ввода числа
{
    Console.WriteLine("Введёное число не является целым положительным"); // Обратная вязь пользователю
}

else
{
    int sumDigit = SumDigit(number); // Вызов метода
    Console.WriteLine($"Резульат вычисления суммы цифр числа {number} = {sumDigit}"); // Вывод результата
}

int SumDigit(int num) // Метод
{
    int sum = 0;
    int lastDigit = 0;
    while (num > 0)
    {
        lastDigit = num % 10;
        sum = sum + lastDigit;
        num = num / 10;
    }
    return sum;
}
