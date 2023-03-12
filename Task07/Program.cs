// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру 
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 10 > 0 && number > 99 && number < 1000)
{
    Console.Write($"Последняя цифра введенного числа {number % 10}");
}

else if (number % 10 < 0 && number < -99 && number > -1000)
{
    Console.Write($"Последняя цифра введенного числа {(number % 10) * -1}");
}

else
{
    Console.Write("Введено не трёхзначное число");
}