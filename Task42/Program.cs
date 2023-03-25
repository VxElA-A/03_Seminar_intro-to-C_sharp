// Напишите программу, которая будет преобразовывать
// десятичное чисо в двочное.
//
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumCheck(number));

string NumCheck(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
