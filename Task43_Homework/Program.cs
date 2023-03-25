// Задача 43: Напишите программу, которая найдет точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1 * x = k2 * x + b2 - b1
// k1 * x - k2 * x = b2 - b1
// x*(k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1 - k2)

Console.WriteLine("Введите число b1");
double numberB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k1");
double numberK1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b2");
double numberB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k2");
double numberK2 = Convert.ToInt32(Console.ReadLine());

CalcDot(numberB1, numberK1, numberB2, numberK2);

void CalcDot(double b1, double k1, double b2, double k2)
{
    if (k1 != k2 && b1 != b2)
    {
        double numX = (b2 - b1) / (k1 - k2);
        double numY = k1 * numX + b1;
        double numXround = Math.Round(numX, 1, MidpointRounding.ToZero);
        double numYround = Math.Round(numY, 1, MidpointRounding.ToZero);
        Console.WriteLine($"Точка пересечения двух прямых -> ({numXround}; {numYround})");
    }

    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
