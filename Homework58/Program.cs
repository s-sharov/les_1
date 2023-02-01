/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */



int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}


void CreateMatrixMultiplMatrices(int[,] matrix1, int[,] matrix2, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}


int[,] array1 = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrixInt(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(2, 3, 1, 10);
PrintMatrixInt(array2);
Console.WriteLine();
if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    CreateMatrixMultiplMatrices(array1, array2, resultArray);
    PrintMatrixInt(resultArray);
}
else
    Console.WriteLine("Эти матрицы невозвомжно перемножить между собой.");