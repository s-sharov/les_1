/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
    Console.WriteLine("Вы ввели не пятизначное число.");
else
    Console.WriteLine(isPalindrome(number) ? $"{number} -> Да" : $"{number} -> Нет");

bool isPalindrome(int num)
{
    int imitNumber = 0;
    int count = num;
    while (count > 0)
    {
        imitNumber *= 10;
        imitNumber += count % 10;
        count /= 10;
    }
    if (imitNumber == num)
        return true;
    return false;
}