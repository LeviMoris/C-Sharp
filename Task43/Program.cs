﻿/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


// Ввод значений b1, k1, b2 и k2 с помощью консоли
Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
if(b1 == b2 && k1 == k2)
{
Console.WriteLine($"при идентичных значениях(K1)=(K2) и (В1)=(В2) это индентичные прямые");
return;
}
if(k1 == k2)
{
Console.WriteLine($"при идентичных значениях(K1)=(K2) пересечение прямых невозможно");
return;
}
// Нахождение точки пересечения двух прямых
/*
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

// Вывод результата
Console.WriteLine("Точка пересечения двух прямых: ({0}; {1})", x, y);