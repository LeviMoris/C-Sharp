// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


int[,,] CreateMatrix3DRndInt(int rows, int columns, int deep, int min = -10, int max = 10)
{
    //                         0     1      2
    int[,,] matrix = new int[rows, columns, deep];

    Random rnd = new Random();
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        Console.WriteLine();
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            Console.Write("|");
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                Console.Write($"{matrix[x, y, z], 5}({x},{y},{z}) ");
            }
            Console.WriteLine("|");
        }
    }
}

int[,,] array3d = CreateMatrix3DRndInt(4, 3, 3, 1, 9);
PrintMatrix3D(array3d);
