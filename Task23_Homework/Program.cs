// Задача 19: Напишите программу, которая
// принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число"); // Приглашение пользователя на ввод
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) // Проверка положительности числа
{
    TableQube(number); // Вызов метода
}
else
{
    Console.WriteLine("Введено некорректное число");
}

void TableQube(int num) // Метод без выдачи
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,4} -> {i * i * i,4}");
        i++;
    }
}