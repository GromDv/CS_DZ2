﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetSecondDigit(int param)
{
    param /= 10;    // уменьшаем до 2-х разрядов
    param %= 10;    // получаем младший разряд
    return param;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)   // проверяем, что разрядов более, чем 2
{
    int secDig = GetSecondDigit(num);
    Console.WriteLine($"Вторая цифра числа {num} равна {secDig}");
}
else
{
    Console.WriteLine("Число имеет менее 3-х знаков!");
}