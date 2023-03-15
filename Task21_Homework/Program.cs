// Задача 19: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11,53

Console.WriteLine("Введите координаты точки A"); // Ввод трёх координат точки А (+ приглашение)
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B"); // Ввод трёх координат точки B (+ приглашение)
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, zA, xB, yB, zB); // Вызов метода
double distRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);


double Distance(int x1, int y1, int z1, int x2, int y2, int z2) // Метод
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}