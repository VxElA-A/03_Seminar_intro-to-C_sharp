// 20. Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D 
// пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Используем формулу A1A2 = корень кв от (х2-х1)2 + (у2-у1)2
// для извлечения корня используем встроенный класс математических функций Math.Sqrt(число)
// округление числа double d = 5,09987354; -> что бы округлить число d, необходимо ввести double dRound = Math.Round(d, 2, MidpointRounding.ToZero); 
// где 2 - это кол-во знаков после запятой, а MidpointRounding - это стратегия округления, а .ToZero - одна из 5-ти стратегий.


Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, xB, yB);
double distRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);


double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

// Немного другое решение:

// Console.WriteLine("Введите координаты точки 1");
// Console.Write("X1 ");
// int x1Coordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y1 ");
// int y1Coordinate = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки 2");
// Console.Write("X2 ");
// int x2Coordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y2 ");
// int y2Coordinate = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
// double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
// Console.WriteLine(distanceRound);

// double Distance(int x1, int y1, int x2, int y2)
// {
//    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// }