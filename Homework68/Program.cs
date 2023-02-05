/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < 0 || secondNumber < 0) 
    Console.WriteLine("Вы ввели не натуральное число.");
else
    Console.WriteLine(Convert.ToInt64(Ackermann(firstNumber, secondNumber)));

int Ackermann(int firstNum, int secondNum)
{
    if(firstNum == 0)
        return secondNum + 1;
    else if(secondNum == 0)
        return Ackermann(firstNum - 1, 1);
    else
        return Ackermann(firstNum - 1, Ackermann(firstNum, secondNum - 1));
}