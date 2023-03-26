﻿// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число");
int lastDigit = number % 10;
System.Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");