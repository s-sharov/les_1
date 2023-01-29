/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}
void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}| ");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("|");
    }
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{Math.Round(arr[i], 1), 5}| ");
        else
            Console.Write($"{Math.Round(arr[i], 1), 5}  ");
    }
    Console.WriteLine("|");
}

double[] FindArithmeticMatrixColumn(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            arr[j] += matrix[i, j];
        }
        arr[j] = arr[j]/arr.Length;
    }
    return arr;
}


int[,] array = CreateMatrixRndInt(4, 4, 1, 10);
Console.WriteLine("Matrix:");
PrintMatrixInt(array);
double[] array2 = FindArithmeticMatrixColumn(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array2);

