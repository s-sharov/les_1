/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Write("Введите число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно число:");
int numberThree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введенные вами числа - {numberOne} , {numberTwo} , {numberThree}");

Console.Write("Самое большое число из них равно ");
if (numberOne > numberTwo)
{
    Console.WriteLine(numberOne);
}
else if (numberTwo > numberThree)
{
    Console.WriteLine(numberTwo);
}
else
{
    Console.WriteLine(numberThree);
}
