// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

bool WeekEnd(int num) // Расположил метод выше всей программы
{
    return num == 6 || num == 7;
}

// Основная программа:

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Некорректный ввод");
}

else
{
    bool weekEnd = WeekEnd(number);
    Console.WriteLine(weekEnd ? "Да" : "Нет");
}