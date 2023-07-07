// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = LengthNumber(number);

Console.WriteLine($"{number} -> {result}");

int LengthNumber(int num)
{
    int count = 0;
    int sum = num %10;
    while (num != 0)
    {
        num = num / 10;
        sum = sum + num %10;
        count++;
    }
    return sum;
}