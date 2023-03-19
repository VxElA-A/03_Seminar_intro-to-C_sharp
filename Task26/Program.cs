// Задача 26: Напишите программу, которая принимает
// на вход число и выдает количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int quantityDigit = QuantityDigit(number);
Console.WriteLine($"Количество цифр в числе = {quantityDigit}");

int QuantityDigit(int num)
{
    int sum = 0;
    while  (num != 0)
    {
        num = num / 10;
        sum = sum + 1;
    }
    return sum;
}