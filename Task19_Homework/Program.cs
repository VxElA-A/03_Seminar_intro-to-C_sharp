// Задача 19: Напишите программу, которая
// принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: "); // Приглашение к вводу числа
int number = Convert.ToInt32(Console.ReadLine()); // Прием пятизначного числа

if (number < 10000 || number > 99999) // Проверка пятизначности числа
{
    Console.WriteLine("Введёное число не является пятизначным"); // Обратная вязь пользователю
}

else
{
    bool fiveDigit = FiveDigit(number); // Вызов метода
    Console.WriteLine(fiveDigit ? $"{number} -> Да" : $"{number} -> Нет"); // Вывод результата
}

bool FiveDigit(int num) // Метод
{
    int first = num / 10000;
    int fifth = num % 10;
    int second = (num / 1000) % 10;
    int fourth = (num % 100) / 10;
    return first == fifth && second == fourth;
}
