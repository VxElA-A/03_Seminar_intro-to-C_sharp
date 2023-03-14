// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. 
//Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите ПЕРВОЕ число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int divResult = DivResult(number1, number2); // Вызов метода

if (divResult==0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток {divResult}");

int DivResult(int num1, int num2) // Метод, но он почему то выглядит сложнее чем без него
{
    return num1 % num2;
}