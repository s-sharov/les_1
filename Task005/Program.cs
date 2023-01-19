/* int[] CreateArrayRandomInt(int size, int start, int end)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end);
    }
    return array;
}

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else 
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

 */
/* int[] array = CreateArrayRandomInt(5, -100, 100);
PrintArrayInt(array);
double[] array = CreateArrayRndDouble(5, -100, 100);
PrintArrayDouble(array); */

/* Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* 
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = tmp;
    }
}

int[] array = CreateArrayRandomInt(5, 1, 11);
PrintArrayInt(array);
ReverseArray(array);
PrintArrayInt(array); */


/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

/* Console.Write("Введите первую сторону: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int sA, int sB, int sC)
{
    if(sA > sB + sC)
        return false;
    else if(sB > sC + sA)
        return false;
    else if(sC > sA + sB)
        return false;
    return true;
}

if(IsTriangle(sideA, sideB, sideC))
    Console.WriteLine("Треугольник с этими сторонами может существовать.");
else
    Console.WriteLine("Треугольник с этими сторонами не может существовать.");
 */

/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
/* 

int ConvertBinaryNotation(int num)
{
    int count = 0;
    int i = 1;
    while(num != 0)
    {
        count += num % 2 * i;
        num /= 2;
        i *= 10;
    }
    return count;
}

Console.WriteLine(ConvertBinaryNotation(45)); */
/* 

int[] GetFibonacciArray(int size)
{
    int[] result = new int[size];
    result[1] = 1;
    for(int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}
void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else 
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] array = GetFibonacciArray(5);
PrintArrayInt(array); */

int[] CreateArrayRandomInt(int size, int start, int end)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end);
    }
    return array;
}

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else 
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] CopyArrayInt(int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = arr[i];
    }
    result[0] = -100;
    return result;
}

int[] arrayOrigin = CreateArrayRandomInt(5, 1, 10);
PrintArrayInt(arrayOrigin);
int[] arrayCopy = CopyArrayInt(arrayOrigin);
PrintArrayInt(arrayCopy);
