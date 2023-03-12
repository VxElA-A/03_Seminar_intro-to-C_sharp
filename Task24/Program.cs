
// Console.Writeline("Введите целое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumNumbers = SumNumbers(number);
// Console.Writeline($"Сумма чисел от 1 до {number} = {sumNumbers}");

// int SumNumbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }




Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number); //7
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num) // 7
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + i;
    }
    return sum; // 28
}