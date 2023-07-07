// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB <= 0)
{
    Console.WriteLine("Ошибка ввода!");
}
int result = Extent(numberA, numberB);
Console.WriteLine(result);

int Extent(int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}