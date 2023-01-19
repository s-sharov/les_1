/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

double FindPointX(int fK1, int fK2, int fB1, int fB2)
{
    double result = 0;
    double i = fK1 - fK2;
    double j = fB2 - fB1;
    //result = (fB2 - fB1) / (fK1 - fK2);// ПОЧЕМУ ТАК ВЫДАЕТ 0?
    result = j / i;//А ТАК КОРРЕКТНОЕ ЗНАЧЕНИЕ
    return Math.Round(result, 1);
}

double FindPointY(double x, int fK2, int fB2)
{
    double result = 0;
    // y = k2 * x + b2;
    result = fK2 * x + fB2;
    return Math.Round(result, 1);
}

double x = FindPointX(k1, k2, b1, b2);
double y = FindPointY(x, k2, b2);

Console.WriteLine($"({Math.Round(x, 1)}, {Math.Round(y, 1)})");


