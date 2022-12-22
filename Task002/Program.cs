/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
 */

/* int number = new Random().Next(10, 100); */
/* int result = number / 10 > number % 10 ? 
    number / 10 : number % 10;
Console.WriteLine($"{number} -> {result}"); */

/* Console.WriteLine($"{number} -> {MaxDigit(number)}");

int MaxDigit(int num)
{
    return num / 10 > num % 10 ? 
        num / 10 : num % 10;
} */

/* 11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
 */
/* int number = new Random().Next(100, 1000);

Console.WriteLine($"{number} -> {DeleteDigit(number)}");
int DeleteDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return firstDigit * 10 + lastDigit;
}
 */



/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
 */


/* Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultipleDigits(firstNumber, secondNumber));

bool MultipleDigits(int firstNum, int secondNum)
{
    return firstNum % secondNum == 0 ? true 
        : $"Не кратно, остаток{firstNum % secondNum} ";
} */


/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
 */

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BothMultiple(number) ? "Да" : "Нет");

bool BothMultiple(int num, int num1 = 7, int num2 = 23)
{
    return num % num1 == 0 && num % num2 == 0;
} */


/* 16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

