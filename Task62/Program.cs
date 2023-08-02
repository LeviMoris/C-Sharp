// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateSpiralMatrixInt(int rows, int columns)
{
    //                     0      1
    int[,] arr = new int[rows, columns];
    int top = 0,
        bottom = rows - 1,
        left = 0,
        right = columns - 1;
    int count = 1;

    while (count <= rows * columns)
    {
        // Заполнение верхней границы слева направо
        for (int i = left; i <= right; i++)
        {
            arr[top, i] = count++;
        }
        top++;

        // Заполнение правой границы сверху вниз
        for (int i = top; i <= bottom; i++)
        {
            arr[i, right] = count++;
        }
        right--;

        // Заполнение нижней границы справа налево
        for (int i = right; i >= left; i--)
        {
            arr[bottom, i] = count++;
        }
        bottom--;

        // Заполнение левой границы снизу вверх
        for (int i = bottom; i >= top; i--)
        {
            arr[i, left] = count++;
        }
        left++;
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //                             форматирование строк
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

PrintMatrix(CreateSpiralMatrixInt(4, 5));
