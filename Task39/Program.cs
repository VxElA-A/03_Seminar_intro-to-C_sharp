// Задача 39. Напишите программу, которая перевернет
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т. д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 10);
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

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

Console.WriteLine("Введите число элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);










// void ReverseArray(int[] arr)
// {
//     int size = arr.Length / 2;
//     if (arr.Length % 2 != 0) size += 1;
//     int[] newArr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newArr[i] = arr[i] * arr[arr.Length - i - 1];
//     }
//     if (arr.Length % 2 != 0)
//     {
//         newArr[size - 1] = arr[arr.Length / 2];
//     }
//     return newArr;
// }