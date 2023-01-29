// Задача No11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число ");

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;

// 123 / 100 = 1, 123 % 10 = 3.

int result = a1 * 10 +a2;

Console.WriteLine({num} {result});

