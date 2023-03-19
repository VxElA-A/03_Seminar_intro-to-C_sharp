// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// Random rnd = new Random();
// int month  = rnd.Next(1, 13);  // creates a number between 1 and 12
// int dice   = rnd.Next(1, 7);   // creates a number between 1 and 6
// int card   = rnd.Next(52);     // creates a number between 0 and 51



int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
// int[] array = Array8(arr);


// int[] Array8(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }



// int[] array = new int[8];

FillArray(array);
WriteArray(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
}