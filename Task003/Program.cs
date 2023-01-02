/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

/* Console.WriteLine("Введите координаты точки (X и Y)");
Console.Write("X = ");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int coordY = Convert.ToInt32(Console.ReadLine());
if(Quarter(coordX, coordY) == 0)
    Console.WriteLine("Одна из координат равна нулю.");
else
    Console.WriteLine($"Номер четверти плоскости, в которой находится ваша точка равна: {Quarter(coordX, coordY)}");
int Quarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    if(x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;
    if(x > 0 && y < 0)
        return 4;
    return 0;
} */


/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */
/* Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if(Quarter(quarter) == "0")
    Console.WriteLine("Введено неверное число четверти.");
else
    Console.WriteLine($"Диапозон координат в заданой четверти: {Quarter(quarter)}");
string Quarter(int q)
{
    if(q == 1) return "x > 0, y > 0";
    if(q == 2) return "x < 0, y > 0";
    if(q == 3) return "x < 0, y < 0";
    if(q == 4) return "x > 0, y < 0";
    return "0";
} */

/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

/* Console.WriteLine("Введите координаты первой точки: ");
int coordA1 = Convert.ToInt32(Console.ReadLine());
int coordA2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
int coordB1 = Convert.ToInt32(Console.ReadLine());
int coordB2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками равно: {Distance(coordA1, coordA2, coordB1, coordB2)}");

double Distance(int coordX1, int coordY1, int coordX2, int coordY2)
{
    double find1 = Math.Pow(coordX2 - coordX1, 2);
    double find2 = Math.Pow(coordY2 - coordY1, 2);
    double result = Math.Sqrt(find1 + find2);
    return Math.Round(result, 2, MidpointRounding.ToZero);
} */


/* Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

/* Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count}\t{Math.Pow(count, 2)}");
        count++;
    }
} */