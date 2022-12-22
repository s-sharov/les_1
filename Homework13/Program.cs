

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 || number < -99)
{
    Console.WriteLine($"Третья цифра вашего числа: {SerchThirdDigit(number)}");
}
else
{
    Console.WriteLine("Третьей цифры в вашем числе нет.");
}

int SerchThirdDigit(int num)
{
    if(num < -99)
    {
        num = -num;
    }
    int count = num;
    while(count > 999)
    {
        num = num / 10;
        count = num;
    }
    return num % 10;
}