// Задаче 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число А в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите ПЕРВОЕ целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ВТОРОЕ целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int expNumbers = ExpNumbers(number1, number2);

if (number2 > 0)
{
    Console.WriteLine($"Резульат возведения числа {number1} в степень {number2} = {expNumbers}");
}

else
{
    Console.WriteLine($"Введено {number2}, для вычисления степени требуется ввод целого положительного числа, т. е. больше нуля");
}

int ExpNumbers(int num1, int num2)
{
    int result = num1;
    for (int i = 2; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
