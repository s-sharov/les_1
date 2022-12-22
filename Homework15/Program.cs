/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number < 8)
{
    if(SerchWeekendsDays(number))
    {
        Console.WriteLine("Данный день недели является выходным.");
    }
    else
    {
        Console.WriteLine("Данный день недели не является выходным.");
    }
}
else
{
    Console.WriteLine("Нет дня недели с таким номером.");
}

bool SerchWeekendsDays(int num)
{
    switch(num)
    {
        case 6:
            return true;
        case 7:
            return true;
        default:
            return false;
    }
}