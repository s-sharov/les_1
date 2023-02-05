

/* Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) 
    Console.WriteLine("Вы ввели не натуральное число");
else
    NaturalNumbers(number);

void NaturalNumbers(int num)
{
    
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
    
} */

/* Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

/* Console.Write("Введите натуральное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно натуральное число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne < 0 || numberTwo < 0 || numberOne > numberTwo) 
    Console.WriteLine("Вы ввели не натуральное число или первое число больше второго");
else
    NaturalNumbers(numberOne, numberTwo);

void NaturalNumbers(int numOne, int numTwo)
{
    if (numOne > numTwo) return;
    Console.Write($"{numOne} ");
    NaturalNumbers(numOne + 1, numTwo);
} */

/* Задача 67: Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12 
45 -> 9 */
