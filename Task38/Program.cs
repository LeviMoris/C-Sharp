// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = "; ", int round = 1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}{sep}");
        else Console.Write($"{num}");
    }
}

double GetMaxNumber(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double GetMinNumber(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double GetDifferenceMinMaxNumbers(double max, double min)
{
    double result = max - min;
    return result;
}


double[] array = CreateArrayRndDouble(5, 0, 20);
Console.Write("[");
PrintArrayDouble(array);
Console.Write("]");
Console.WriteLine();

double maxNumber = GetMaxNumber(array);
double minNumber = GetMinNumber(array);

double differenceMinMaxNumbers = Math.Round(GetDifferenceMinMaxNumbers(maxNumber, minNumber), 1);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {differenceMinMaxNumbers}");