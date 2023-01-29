/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет */

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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}

bool ExistElementMatrixInt(int[,] matrix, int row, int col)
{
    if(row < 0 || 
    row >= matrix.GetLength(0) || 
    col < 0 || 
    col >= matrix.GetLength(1))
        return false;
    return true;
}

Console.WriteLine("Enter row and column:");
int rowUser = Convert.ToInt32(Console.ReadLine());
int columnUser = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateMatrixRndInt(4, 4, -100, 100);
Console.WriteLine("Matrix:");
PrintMatrixInt(array);
if(ExistElementMatrixInt(array, rowUser, columnUser))
    Console.WriteLine($"Element {rowUser}, {columnUser}: {array[rowUser, columnUser]}");
else
    Console.WriteLine("Element not found");

