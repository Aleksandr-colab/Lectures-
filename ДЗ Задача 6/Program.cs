﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Введите число");
int even = int.Parse(Console.ReadLine()!);


if (even % 2 != 0)
{
    Console.WriteLine("Данное число не четное");
}
else
{
    Console.WriteLine("Данное число четное");
}