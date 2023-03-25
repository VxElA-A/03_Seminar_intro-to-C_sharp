// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте сколько чисел больше нуля ввел пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223, -> 3

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й номер элемента массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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
        if(arr[i] > 0) sum++;
    }
    return sum;
}

Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
Console.WriteLine("Ваш массив: ");
PrintArray(array);

int numberExist = NumberExist(array);
Console.WriteLine($"Количество положительных элементов массива -> {numberExist}");