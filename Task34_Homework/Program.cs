// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int NumberExist(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) sum++;
    }
    return sum;
}

Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
int numberExist = NumberExist(array);
Console.WriteLine($"Количество четных элементов массива -> {numberExist}");