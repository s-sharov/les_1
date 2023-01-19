/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int GetNumPositiveElemArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Индекс {i} = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
FillArray(array);
PrintArrayInt(array);
int result = GetNumPositiveElemArray(array);
Console.WriteLine($"Количество положительных элементов в массиве: {result}");