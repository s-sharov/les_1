/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateArrayRandomInt(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] arr)
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

int FindSumNotEvenElemArray(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            num += arr[i];
    }
    return num;
}

int[] array = CreateArrayRandomInt(5);
PrintArray(array);

int number = FindSumNotEvenElemArray(array);

Console.WriteLine($"Сумма нечетных элементов в массиве: {number}");