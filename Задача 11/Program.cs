﻿// Задача No11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число ");

int a = new Random().Next(100, 1000);

Console.WriteLine($"рандомное число: {a}");
Console.WriteLine($"получилось число: {a / 100 * 10 + a % 10}");

