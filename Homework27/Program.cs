/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} -> {SumDigits(number)}");
int SumDigits(int num)
{
    if(num == 0)
        return num;
    if(num < 0)
        num = -num;
    int result = 0;
    int count = num;
    for(int i = 0; i < num; i++)
    {
        result += count % 10;
        count /= 10;
    }
    return result;
}