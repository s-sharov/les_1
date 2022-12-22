﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
 */


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 999 || number < -99 && number > -999)
{
    Console.WriteLine($"Вторая цифра вашего числа: {SerchSecondDigit(number)}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}

int SerchSecondDigit(int num)
{
    if(num < 0)
    {
        num = -num;
    }
    return (num / 10) % 10;
}