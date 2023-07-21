﻿// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    // 0 1
    int[,] matrix = new int[rows, columns]; // 3 x 4

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = 3
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[] CreateAverageColumn(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        average[i] = sum / matrix.GetLength(0);
    }
    return average;
}
void PrintArray(double[] arr, string sep = ",  ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{Math.Round(arr[i], 1)}{sep}");
        }
        else
        {
            Console.Write($"{Math.Round(arr[i], 1)}");
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(CreateAverageColumn(array2d));
