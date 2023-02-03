/* *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] CreateMatrixInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    int number = 1;
    for (int y = 0; y < col; y++)
    {
        matrix[0, y] = number;
        number++;
    }
    for (int x = 1; x < row; x++)
    {
        matrix[x, col - 1] = number;
        number++;
    }
    for (int y = col - 2; y >= 0; y--)
    {
        matrix[row - 1, y] = number;
        number++;
    }
    for (int x = row - 2; x > 0; x--)
    {
        matrix[x, 0] = number;
        number++;
    }
    int startX = 1;
    int startY = 1;
    while (number < row * col)
    {
        while (matrix[startX, startY + 1] == 0)
        {
            matrix[startX, startY] = number;
            number++;
            startY++;
        }
        while (matrix[startX + 1, startY] == 0)
        {
            matrix[startX, startY] = number;
            number++;
            startX++;
        }
        while (matrix[startX, startY - 1] == 0)
        {
            matrix[startX, startY] = number;
            number++;
            startY--;
        }
        while (matrix[startX - 1, startY] == 0)
        {
            matrix[startX, startY] = number;
            number++;
            startX--;
        }
    }
    for (int x = 0; x < row; x++)
    {
        for (int y = 0; y < col; y++)
        {
            if (matrix[x, y] == 0)
            {
                matrix[x, y] = number;
            }
        }
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
            if (j < matrix.GetLength(1) - 1)
            {
                if (matrix[i, j] < 10)
                    Console.Write("   0" + matrix[i, j] + "| ");
                else
                    Console.Write($"{matrix[i, j],5}| ");
            }
            else
            {
                if (matrix[i, j] < 10)
                    Console.Write("   0" + matrix[i, j] + " ");
                else
                    Console.Write($"{matrix[i, j],5} ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,] matrix = CreateMatrixInt(8, 9);
PrintMatrixInt(matrix);