﻿
Console.WriteLine("Введите номер четверти");
Console.Write("Четверть: ");
int number = Convert.ToInt32(Console.ReadLine());

string cord = Cord(number);
string result = cord != "ERROR" 
                ? $"Указанная четверть соответствует координатам - {cord}" 
                : "Введена некорректная четверть";

Console.WriteLine(result);

string Cord(int num)
{
    if(num == 1) return "x > 0 и y > 0";
    if(num == 2) return "x < 0 и y > 0";
    if(num == 3) return "x < 0 и y < 0";
    if(num == 4) return "x > 0 и y < 0";
    return "ERROR";
}