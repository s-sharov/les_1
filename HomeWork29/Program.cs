﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

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

int[] array = CreateArrayRandomInt(8);
PrintArray(array);