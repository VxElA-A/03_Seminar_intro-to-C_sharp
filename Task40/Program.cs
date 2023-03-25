// Задача 40: Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать треугольник
// со сторонами такой длины 
// (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.)

Console.WriteLine("Введите ПЕРВОЕ число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ВТОРОЕ число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ТРЕТЬЕ число");
int number3 = Convert.ToInt32(Console.ReadLine());

bool triCheck = TriCheck(number1, number2, number3);
Console.WriteLine(triCheck ? "да" : "Нет");

bool TriCheck(int num1, int num2, int num3)
{
   if (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2) return true;
   else return false;
}

// bool TriCheck(int num1, int num2, int num3)
// {
//    return num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2;
// }