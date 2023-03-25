// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Console.WriteLine("Введите ПЕРВОЕ целое положительное число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите ВТОРОЕ целое положительное число: ");
// int numberM = Convert.ToInt32(Console.ReadLine());


// if (numberN > numberM)
// {
//     NaturalNumbers1(number);
// }

// else if (numberN < numberM)
// {
//     NaturalNumbers2(number);
// }

// else
// {
//     NaturalNumbers3(number);
// }

// void NaturalNumbers1(int numN, int numM)
// {
//     if (num == 0) return;
//     NaturalNumbers1(num - 1);
//     Console.Write($"{num} ");
// }


// void NaturalNumbers2(int numN, int numM)
// {
//     if (num == 0) return;
//     NaturalNumbers1(num - 1);
//     Console.Write($"{num} ");
// }

// void NaturalNumbers3(int numN, int numM)
// {
//     if (num == 0) return;
//     NaturalNumbers1(num - 1);
//     Console.Write($"{num} ");
// }

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
NaturalNumbersMtoN(numberM, numberN);

void NaturalNumbersMtoN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM + 1, numN);
    }

    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersMtoN(numM - 1, numN);
    }

    else
    {
        Console.Write($"{numM}");
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}