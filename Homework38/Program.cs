﻿/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

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

double FindMaxNumArray(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) 
            max = arr[i];
    }
    return max;
}

double FindMinNumArray(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) 
            min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(5, -100, 100);
PrintArrayDouble(array);
double maxNum = FindMaxNumArray(array);
double minNum = FindMinNumArray(array);
double result = Math.Round(maxNum - minNum, 1);
if(minNum < 0)
    result = Math.Round(maxNum - (minNum * -1), 1);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");


