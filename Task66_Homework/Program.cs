// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
int sum = NaturalNumbersMtoN(numberM, numberN);
Console.Write($"{sum} ");

int NaturalNumbersMtoN(int numM, int numN)
{
    if (numM < numN) return numM + NaturalNumbersMtoN(numM + 1, numN);
    else if (numM > numN) return numM + NaturalNumbersMtoN(numM - 1, numN);
    else return numM + numN;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}