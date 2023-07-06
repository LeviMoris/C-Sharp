// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
Console.WriteLine(newNumber(number));

bool newNumber(int num)
{
    string texNumber = Convert.ToString(num);
    char[] arrayNumber = texNumber.ToArray();
    Array.Reverse(arrayNumber);
    string strNumber = new String(arrayNumber);
    int newNum = Convert.ToInt32(strNumber);
    bool result = num == newNum;
    return result;
}