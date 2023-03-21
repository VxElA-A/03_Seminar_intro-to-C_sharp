// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArrayDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rand.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double GetMaxElemDouble(double[] arr)
{
    double maxElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxElem < arr[i]) maxElem = arr[i];
    }
    return maxElem;
}

double GetMinElemDouble(double[] arr)
{
    double minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minElem > arr[i]) minElem = arr[i];
    }
    return minElem;
}

Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива");
int numberMax = Convert.ToInt32(Console.ReadLine());

double[] array = FillArrayDouble(number, numberMin, numberMax);

PrintArrayDouble(array);

double getMaxElemDouble = GetMaxElemDouble(array);
double getMinElemDouble = GetMinElemDouble(array);
double sum = getMaxElemDouble - getMinElemDouble;

if (numberMax <= numberMin || number <= 0)
{
    Console.WriteLine("Ошибка, проверьте ввод параметров массива");
}

else
{
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(sum, 1)}");
}
