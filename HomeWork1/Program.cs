//Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число = {numberOne}; Второе число = {numberTwo}");
if (numberOne > numberTwo)
{
    Console.WriteLine($"Первое число больше второго и равно {numberOne}");
}
else
{
    Console.WriteLine($"Второе число больше первого и равно {numberTwo}");
}