/* Console.Write("Введите число:");
string number = Console.ReadLine();
switch (number)
{
    case "1":
        {
            Console.WriteLine("Понедельник"); //
            break;
        }
    case "2":
        {
            Console.WriteLine("Вторник");
            break;
        }
    case "3":
        {
            Console.WriteLine("Среда");
            break;
        }
    case "4":
        {
            Console.WriteLine("Четверг");
            break;
        }
    case "5":
        {
            Console.WriteLine("Пятница");
            break;
        }
    case "6":
        {
            Console.WriteLine("Суббота");
            break;
        }
    case "7":
        {
            Console.WriteLine("Воскресенье");
            break;
        }
    default :
            Console.WriteLine("Нет дня недели с таким номером.");
            break;
} */


/* 7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8
 */
Console.Write("Введите трёхзначное числа - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
    Console.Write($"Последняя цифра в числе {number} равна {number % 10}");
else
    Console.Write("Вы ввели не трехзначное число");


/* 5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
Итерация №2
Решение в группах задач: 20 мин
 */
/* Console.Write("Введите числа - ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
} */

    
