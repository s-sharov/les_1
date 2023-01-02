/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.WriteLine("Введите координаты первой точки: ");
Console.Write("AX: ");
int coordAX = Convert.ToInt32(Console.ReadLine());
Console.Write("AY: ");
int coordAY = Convert.ToInt32(Console.ReadLine());
Console.Write("AZ: ");
int coordAZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("BX: ");
int coordBX = Convert.ToInt32(Console.ReadLine());
Console.Write("BY: ");
int coordBY = Convert.ToInt32(Console.ReadLine());
Console.Write("BZ: ");
int coordBZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками равно: {Distance(coordAX, coordAY, coordAZ, coordBX, coordBY, coordBZ)}");

double Distance(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
    double find1 = Math.Pow(coordX2 - coordX1, 2);
    double find2 = Math.Pow(coordY2 - coordY1, 2);
    double find3 = Math.Pow(coordZ2 - coordZ1, 2);
    double result = Math.Sqrt(find1 + find2 + find3);
    return Math.Round(result, 2, MidpointRounding.ToZero);
} 