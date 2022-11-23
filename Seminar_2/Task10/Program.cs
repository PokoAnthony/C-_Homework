﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Введите трёхзначное число!");
}

else if (num < 1000 && num > 99)
{
    num = num % 100;
    Console.WriteLine("Вторая цифра этого числа является: " + num / 10);
}