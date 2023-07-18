// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько чисел Вы хотите ввести?");
int valueNumbers = Convert.ToInt32(Console.ReadLine());
if (valueNumbers <= 0)
{
    Console.WriteLine("Ошибка ввода. Введите положительное число");
}

int[] arrNumbers = Array(valueNumbers);
Console.Write("[");
PrintArray(arrNumbers);
Console.Write("]");

int sumNumbersOverZero = GetSumNumbersOverZero(arrNumbers);
Console.Write(" Количество чисел больше 0 -> ");
Console.Write(sumNumbersOverZero);

int[] Array(int valNum)
{
    int[] arr = new int[valNum];
    for (int i = 0; i < valNum; i++)
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}

int GetSumNumbersOverZero(int[] arrNumbers)
{
    int sum = 0;
    for (int i = 0; i < arrNumbers.Length; i++)
    {
        if (arrNumbers[i] > 0)
        {
            sum += 1;
        }
    }
    return sum;
}

void PrintArray(int[] arr, string sep = ", ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
}
